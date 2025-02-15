import { Component } from "react";


export class Counter extends Component{
   
    constructor(props)
    {
        super(props);
        this.state ={
            count :0
        };
    }
    
    Increment = () =>{
        this.setState(
         {count: this.state.count + 1}
        )
        

    }

    Decrement = () =>{
        this.setState(
         {count: this.state.count - 1}
        )
    }
    render()
    {
        return (
            <>
            <h2>Counter : {this.state.count}</h2>
            <button onClick={this.Increment}>Counter</button>
            </>
        )
    }
}