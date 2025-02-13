var fs = require("fs");
//var data = fs.readFileSync('sizing.txt');
fs.readFile('sizing.txt',function (err,data){
    if(err) return console.error(err);
    console.log(data.toString());

});

let i = 1;
while (i <=5) {
  console.log("The number is " + i);
  i++;
}