let arr = [];

class Service {
    addObject(object){
        object.id = String(arr.length);
        arr.push(object);
    }

    getObjectById(id){
        const elem = arr.find((el) => el.id === id);

        if(elem){
            console.log("Object found by ID: ")
            console.log(elem);
        } 

        else {
            console.log(null);
        }
    }

    getAllObjects(arr){
        console.log("Array: ")
        console.log(arr);
    }

    deleteObjectById(id){
        const elem = arr.find((el) => el.id === id);

        if(elem){
            arr.splice(id)
            console.log("Deleted object: ")
            console.log(elem);
        } 

        else {
            console.log("This object does not exist");
        }
    }

    updateObjectById(id, object){
        const elem = arr.find((el) => el.id === id);
        if(elem){
            for(let i = 0; i < arr.length; i++){
                Object.assign(elem, object);
            }
        } 

        else {
            console.log("This object does not exist");
        }
    }

    replaceObjectById(id, object){
        const elem = arr.find((el) => el.id === id);

        if(elem){
            for(let i = 0; i < arr.length; i++){
                arr.splice(i, 1, object);
            }
        } 

        else {
            console.log("This object does not exist");
        }
    }
}

var storage = new Service();

storage.addObject({band: "Slipknot", genre : "nu metal"}); 
storage.addObject({band: "Motionless in White", genre : "metalcore"});

storage.getAllObjects(arr);