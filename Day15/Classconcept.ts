class Product
{
   private id:number;
    proname:string;
    proprice:number;
    readonly qty:number;

    constructor(id:number,proname:string,proprice:number,quantity:number)
    {
        this.id = id;
        this.proname = proname;
        this.proprice = proprice;
        this.qty=quantity;
    }
    
    Display()
    {
        return `${this.id} ${this.proname} ${this.proprice}`;
    }
}
let produ = new Product(123,'Laptop',80000,12)
console.log(produ.Display());


//produ.qty=10;//compile error - Readonly property cannot be reinitialized

