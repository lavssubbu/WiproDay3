function samp()
{
    let age = prompt('Enter your age:',25);

    alert(`your age is ${age}`);

   let crm = confirm("Do you want to continue");
   alert(crm);
}

function validate()
{
  let nm =  document.getElementById("name").value;
  if(nm === "")
    {
        alert("Name cannot be Empty");
        return false;
      
    }
    else{
        alert(`Your typed name is ${nm} `);
        return true;
    }
}

function castnumber()
{
    let num="20";
    let nmm=Number(num);
    alert(`${nmm+5}`);
    console.log(nmm);
}

function Arrayloop()
{
    let city = ["Chennai","Mumbai","Hyderabad"];
    let outpt = "";
    for(let cities of city)
    {
        console.log(cities);
    }
}

function showDate()
{
    try{
        let todaydate = new Date();
        alert("Current Date:"+todaydate.toLocaleDateString());
    }
    catch(error)
    {
       alert("Error:"+error.message);
    }
    
    
}

function fetchdata()
{
    fetch("https://jsonplaceholder.org/users")
    .then(response =>response.json())
    .then(data => console.log(data));
}