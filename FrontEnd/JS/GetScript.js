
function Added() {
    var x = document.getElementById("snackbar");
    // Add the "show" class to DIV
   x.classList.add("show");
  // After 3 seconds, remove the show class from DIV
  setTimeout(function(){ x.classList.remove("show")}, 3000);
}

//student data with marks, subject, and name
const getAllStudentsData = async () => {
  try {
    let response = await fetch("http://localhost:61542/api/Employee/students/1");
    let data = await response.json();
    const tbody = document.getElementById("tableBody");
  
    console.log(typeof(data));
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
if(document.getElementById("tableBody")){console.log(getAllStudentsData());}

//Get ALL Students
const getAllStudents = async (SelectId) => {
  
  try {
    let data;
    if(localStorage.getItem("Student_Id"))
      {
        data=JSON.parse(localStorage.getItem("Student_Id"));
      }
    else{
    let response = await fetch("http://localhost:61542/api/Employee/Students");
    data = await response.json();
    localStorage.setItem("Student_Id", JSON.stringify(data));
    }
    const S_ID = document.getElementById(SelectId);
    console.log(typeof(data));
    console.log(SelectId);
    S_ID.innerHTML = `<option value="" > Select a Student </option>`+data.map(item => `
    <option value="${item.student_Id}">${item.name}</option>
    `).join('');

  return data;
    
  }
  catch (error) {
    console.log(error);
  }
}
let AddForm = document.getElementById("AddForm");
// console.log(AddForm)
// let AddStudent= document.getElementById("#StudentForm");



// if(AddStudent){
//  let SelectId=AddStudent.querySelector("#Student_Id");
//   console.log(getAllStudents(SelectId.id));
// }
// console.log(getAllStudents());

//Get ALL Teachers
const getAllTeachers = async (SelectId) => {
  let data;
  try {
    if(localStorage.getItem("Teacher_Id")){
      data=JSON.parse(localStorage.getItem("Teacher_Id"));
    }
    else{
    let response = await fetch("http://localhost:61542/api/Employee/teachers");
    data = await response.json();
    localStorage.setItem("Teacher_Id", JSON.stringify(data));
    }
    const t_id = document.getElementById(SelectId);
    console.log(typeof(data));
    t_id.innerHTML = ""; 
    t_id.innerHTML = `<option value="" class="Options"> Select a Teacher </option>`+data.map(item => `
    <option value="${item.teacher_Id}">${item.name}</option>
    `).join('');
  return data;
    
  }
  catch (error) {
    console.log(error);
  }
}

if(AddForm){
  let SelectId=AddForm.querySelector("#Student_Id");
  let Teacher_Id=AddForm.querySelector("#Teacher_Id");
  console.log(getAllStudents(SelectId.id));
  console.log(getAllTeachers(Teacher_Id.id));
}
// if(document.getElementById("Teacher_Id")){console.log(getAllTeachers("Teacher_Id"));}
// console.log(getAllTeachers());


// Adding Score for the Student
const AddScore = async (student_Id, teacher_Id, Date,Subject,Marks) => {
    try {
    let options = {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({ student_Id, teacher_Id, Date,Subject,Marks})  
    }
    
        let response = await fetch("http://localhost:61542/api/Employee/S",options);
        console.log(response);
        Added(); 
        if (response.ok) {
        console.log("Score added successfully");
        // getAllStudents(); // Refresh the student list
        } else {
        console.error("Failed to add Score");
        }
    } catch (error) {
        console.error("Error adding student:", error);
    }
}

//adding event listener to the form submission  of Add Score
let addScoreForm = document.getElementById("AddForm");
if(addScoreForm) {
addScoreForm.addEventListener("submit", function(event) {
    event.preventDefault(); // Prevent the form from submitting normally
    let Student_Id = document.getElementById("Student_Id").value;
    let Teacher_Id = document.getElementById("Teacher_Id").value;
    let Subject = document.getElementById("Subject").value;
    let Marks = document.getElementById("Marks").value;
    let Date = document.getElementById("Date").value;
    console.log(Student_Id, Teacher_Id, Date, Subject, Marks);
    AddScore(Student_Id, Teacher_Id, Date,Subject,Marks);
    
});
}

//getting Average Marks per Teacher
const GetAverageMarks=async () => {
try {
    let response = await fetch("http://localhost:61542/api/Employee/Teachers/top");
    let data = await response.json();
    const tbody = document.getElementById("AvgMarksTableBody");
    console.log(data);
    tbody.innerHTML = data.map(item => `
    <tr>
      <td>${item.teacherName}</td>
      <td>${item.studentName}</td>
      <td>${item.averageMarks}</td>
    </tr>
  `).join('');
  return data;
    
  }
  catch (error) {
    console.log(error);
  }
}
if(document.getElementById("AvgMarksTableBody")){console.log(GetAverageMarks());}
// console.log(GetAverageMarks());



//Student Score

const GetHighestScore = async () => {
  try {
    let response = await fetch("http://localhost:61542/api/Employee/students/2");
    let data = await response.json();
    const tbody = document.getElementById("highscoreTableBody");
  
    console.log(typeof(data));
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

let  high= document.getElementById("highscoreTableBody");
if(high){GetHighestScore();}

// window.onstorage = (e) => {
//         alert("changed")
//         console.log(e)
// }