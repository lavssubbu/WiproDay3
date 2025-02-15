import react,{ Component } from "react";
import off from './off.png'
import on from './on.png'


export class SampState extends Component{
    
    constructor(props) {
        super(props)
        this.state = {
            msg: "Welcome to Wipro Team",
            imgname: off
        }
    }
    
    ButtonChange = () =>
    {
        this.setState (
            {
                msg:"All the Best",
                imgname:on
            }
        )
    }


    render(){
        return (
           <>
            <h3>{this.state.msg}</h3>
            <img src={this.state.imgname} alt="lightimg"></img>
            <button onClick={this.ButtonChange}>Click Here</button>
           </>
        )
    }
}