import { Component } from "react";


export class Employee extends Component{
   
    constructor(props)
    {
        super(props);
    }



    render()
    {
        return (
            <div>
                <h1>Employee Class Component</h1>
                <h3>{this.props.name}</h3>
             </div>            
        )
    }
}