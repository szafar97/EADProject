function validate()
{
    var title = document.getElementById("title").value;
    var author = document.getElementById("author").value;
    var desc = document.getElementById("desc").value;
    var cat = document.getElementById("category").value;
    var cat1 = document.getElementById("otherC").value;
    var flag = true;
	
	if (title == "")
	{
		document.getElementById("titleW").innerHTML = "Title is required";
		document.getElementById("titleW").className = "warning";
		flag = false;
	}
	else
	{
		document.getElementById("titleW").innerHTML = "";
		document.getElementById("titleW").className = "nowarning";
	}

	if (author == "") {
	    document.getElementById("authorW").innerHTML = "Author is required";
	    document.getElementById("authorW").className = "warning";
	    flag = false;
	}
	else {
	    document.getElementById("authorW").innerHTML = "";
	    document.getElementById("authorW").className = "nowarning";
	}
	
	if (desc == "")
	{
		document.getElementById("descW").innerHTML = "Description is required";
		document.getElementById("descW").className = "warning";
		flag = false;
	}
	else
	{
		document.getElementById("descW").innerHTML = "";
		document.getElementById("descW").className = "nowarning";
	}

	if (cat == "Other")
	{
	    if (cat1 == "")
	    {
	        document.getElementById("otherW").innerHTML = "Enter new category in other textfield";
	        document.getElementById("otherW").className = "warning";
	        flag = false;
	    }
	    else
	    {
	        document.getElementById("otherW").innerHTML = "";
	        document.getElementById("otherW").className = "nowarning";
	    }
	}
	
	return flag;
}