const string = "5.5 + 4.5 * 10 - 50 / 10=";

    function calculate(string){
        let result = 0;
        let matchArray = [];
        let regexList = /\-?\d+(\.\d+)?|[\+,\-,\*,\/,\=]{1}/ig;

        matchArray = string.match(regexList);

        if(matchArray[0]*1 + "" !== "NaN"){
            result += matchArray[0] * 1;
        }

        for(let i = 0;i < matchArray.length; i++){
            switch(matchArray[i]){
                case "+": result += matchArray[i + 1] * 1; 
                	break;
                case "-": result -= matchArray[i + 1] * 1;
                	break;
                case "*": result *= matchArray[i + 1] * 1;
                	break;
                case "/": result /= matchArray[i + 1] * 1;
                	break;
                case "=": break;
                default: 
                	continue; 
                	break;
            }
        }

        return result;
    }

    let result = calculate(string);

    console.log("Expression: " + string); 
    console.log(result.toFixed(2));