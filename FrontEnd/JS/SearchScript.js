const SearchStudentData = async (id) => {
       
  try {
 
    let response = await fetch(`http://localhost:61542/api/Employee/student/${id}`);
    let data = await response.json();
    Added();
    const tbody = document.getElementById("ScoreBody");
     console.log(tbody);
    console.log(typeof(data));
    console.log(tbody);
    tbody.innerHTML = "";
    tbody.innerHTML = data.map(item => `
    <tr>
      <td>${item.name}</td>
      <td>${item.subject}</td>
      <td>${item.marks}</td>
    </tr>
  `).join('');
  return data;
    
  }
  catch (error) {
    console.log(error);
  }
}



function Added() {
    var x = document.getElementById("snackbar");
    // Add the "show" class to DIV
   x.classList.add("show");
  // After 3 seconds, remove the show class from DIV
  setTimeout(function(){ x.classList.remove("show")}, 3000);
}



 getAllStudents(document.getElementById("SearchForm").querySelector("#Student_Id").id);

let DisplayScoreForm = document.getElementById("SearchForm");
if (DisplayScoreForm) {
  DisplayScoreForm.addEventListener("submit", function (event) {
    event.preventDefault();
    const studentId = document.getElementById("Student_Id").value;
    SearchStudentData(studentId);
  });
}