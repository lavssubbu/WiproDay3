

function sum(a:number,b:number) : number{
    return a+b;
}

let res = sum(10,20);

console.log(res);

//Inferring function type

let result = function (a:number,b:number) : number{
    return a+b;
};

let sumval = result(10,45);

console.log(sumval);

//default parameter & optional parameter
function prod(x:number=10,y?:number):number{
    if(typeof y !== 'undefined')
    {
        return x*y;
    }
    return x*x;
}

console.log(prod(20,30));
console.log(prod(30));
console.log(prod());

//rest parameter - 0 to more arguments
function getsumofall(...numbers: number[]):number{
    let tot =0;
    numbers.forEach((num)=> tot+=num); //Iterator
    return tot;
}

console.log(getsumofall(10,40,60,70,70));
console.log(getsumofall(10,40));
console.log(getsumofall());
