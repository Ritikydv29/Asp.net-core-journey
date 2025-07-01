
//get all students data



// const getAllStudents= async () => {
//   try {
//     let response = await fetch("http://localhost:61542/api/Employee/students/1");
//     let data = await response.json();
//     const tbody = document.getElementById("tableBody");
  
//     console.log(typeof(data));
//     tbody.innerHTML = data.map(item => `
//     <tr>
//       <td>${item.name}</td>
//       <td>${item.subject}</td>
//       <td>${item.marks}</td>
//     </tr>
//   `).join('');
//   return data;
    
//   }
//   catch (error) {
//     console.log(error);
//   }
// }

// Add a new student
const AddStudent = async (name, Address, Phone_No,Teacher_Id) => {
    try {
    let options = {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({ name, Address, Phone_No, Teacher_Id })  
    }
    
        let response = await fetch("http://localhost:61542/api/Employee/student",options);
        console.log(response);
        if (response.ok) {
        console.log("Student added successfully");
        // getAllStudents(); // Refresh the student list
        } else {
        console.error("Failed to add student");
        }
    } catch (error) {
        console.error("Error adding student:", error);
    }
}
// let choice =prompt('Enter 1 to add a student, 2 to view all students:');
// if(choice === '1') {
//     let name = prompt('Enter student name:');
//     let Address = prompt('Enter student address:');
//     let Phone_No = prompt('Enter student phone:');
//     let Teacher_Id = prompt('Enter teacher ID:');
//     AddStudent(name, Address, Phone_No, Teacher_Id);
// }
// console.log(getAllStudents());



//teachers Data including Name , Student , Subject, and Marks
const getAllTeachers = async () => {
  try {
    let response = await fetch("http://localhost:61542/api/Employee/teachers");
    let data = await response.json();
    const t_id = document.getElementById("Teacher_Id");
  
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

// console.log(getAllTeachers());


//Adding a Student
let Teachers_data= getAllTeachers();
console.log(Teachers_data);
let addStudentForm = document.getElementById("StudentForm");
addStudentForm.addEventListener("submit", function(event) {
    event.preventDefault(); // Prevent the form from submitting normally
    let name = document.getElementById("name").value;
    let Address = document.getElementById("Address").value;
    let Phone_No = document.getElementById("Phone_No").value;
    let Teacher_Id = document.getElementById("Teacher_Id").value;
    AddStudent(name, Address, Phone_No, Teacher_Id);
    Added(); // Call the Added function to show the snackbar
});

function Added() {
    var x = document.getElementById("snackbar");
    // Add the "show" class to DIV
   x.classList.add("show");
  // After 3 seconds, remove the show class from DIV
  setTimeout(function(){ x.classList.remove("show")}, 3000);
}

