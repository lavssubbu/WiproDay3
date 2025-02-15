import { useState } from "react"


const FuncCounter  = () => {
    //useState hooks to preserve state value in functional components
    const [count,setcount]=useState(0);//initializing the value 0 to count; count=0
    
    const Increment =() =>{
        setcount(prcount =>prcount+1);
      //  alert(count +1);
    }



    return (
        <div>
            <h1>CountValue: {count}</h1>
            <button onClick={Increment}>Add</button>
        </div>
    )
}

export default FuncCounter;