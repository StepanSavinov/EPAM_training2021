let str = "У попа была собака";
let ignored = ["?", "!", ":", ";", ",", ".", " ", "\t", "\r"];
let newStr = {};

str.split(' ').forEach(function (word){
	word.split('').forEach(function (letter, i){
		if (!newStr[letter] && ignored.indexOf(letter) == -1 && -1 != word.indexOf(letter, i + 1)){
			newStr[letter] = 1;
		}
	});
});

let result = str.split('').filter(function (v){
	return !newStr[v];
}).join('');

console.log(result);
