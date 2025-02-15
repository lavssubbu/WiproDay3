
import React from "react";



const BookItem = ({ item, index, showDetails, toggleDetails }) => {
    return (
     <div>
                       <h3>{item.title}</h3>
                            {showDetails && <><p>Author:{item.author}</p>  <p>Genre: {item.genre}</p></>}
                         
                         <button onClick={()=>toggleDetails(index)}>
                            {showDetails ? 'Hide Details' : 'Show Details'}
                            </button>
                       
                       
        </div>
    )
};

export default BookItem;
