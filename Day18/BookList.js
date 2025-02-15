import Book from "./Book"
import React,{ useState } from "react"
import BookItem from "./BookDetail";

export const BookList = () => {

    //List of books initialized using usestate hook
    const [lstbooks] = useState([
        new Book("Book1","Autho1","Horror"),
        new Book("Book2","Autho2","Comics"),
        new Book("Book3","Autho3","Technology")
    ])

    const [showDetils,setShowDetails] = useState(Array(lstbooks.length).fill(false));

    const toggleDetails = (index) =>{
        const updatedetails = [...showDetils];
        updatedetails[index]=!updatedetails[index];
        setShowDetails(updatedetails)
    };
    
     return (
        <div>
        <h1>BookList</h1>
                  {lstbooks.map((item,index) => (
                    <BookItem key={index} item={item} index={index} showDetails={showDetils[index]} toggleDetails={toggleDetails}></BookItem>))}
       </div>
    )
}