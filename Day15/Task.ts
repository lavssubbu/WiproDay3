// Define an interface for Task
interface Task {
    id: number;
    title: string;
    description: string;
    completed: boolean;
}

// Implement the TaskManager class
class TaskManager {
    private tasks: Task[] = [];

    addTask(task: Task): void {
        this.tasks.push(task);
        console.log(`Task added successfully: ${task.title}`);
        renderTasks(); // Update the UI after adding
    }

    viewTasks(): Task[] {
        return this.tasks;
    }

    modifyTask(id: number, updatedTask: Partial<Task>): void {
        const task = this.tasks.find(t => t.id === id);
        if (!task) {
            console.log(`Error: Task with ID ${id} does not exist.`);
            return;
        }
        Object.assign(task, updatedTask);
        console.log(`Task modified successfully: ${task.title}`);
        renderTasks(); // Update the UI after modification
    }

    deleteTask(id: number): void {
        const index = this.tasks.findIndex(t => t.id === id);
        if (index === -1) {
            console.log(`Error: Task with ID ${id} does not exist.`);
            return;
        }
        this.tasks.splice(index, 1);
        console.log(`Task deleted successfully.`);
        renderTasks(); // Update the UI after deletion
    }
}

// Create a global instance of TaskManager
const manager = new TaskManager();

// Function to add a task from HTML input
function addNewTask(): void {
    const titleInput = document.getElementById("taskTitle") as HTMLInputElement;
    const descInput = document.getElementById("taskDesc") as HTMLInputElement;

    if (!titleInput.value || !descInput.value) {
        alert("Please enter a task title and description.");
        return;
    }

    const newTask: Task = {
        id: Date.now(), // Generate unique ID
        title: titleInput.value,
        description: descInput.value,
        completed: false,
    };

    manager.addTask(newTask);

    // Clear input fields
    titleInput.value = "";
    descInput.value = "";
}

// Function to delete a task from HTML
function deleteTask(id: number): void {
    manager.deleteTask(id);
}

// Function to render tasks in the HTML
function renderTasks(): void {
    const taskList = document.getElementById("taskList") as HTMLUListElement;
    taskList.innerHTML = ""; // Clear existing list

    manager.viewTasks().forEach(task => {
        const li = document.createElement("li");
        li.innerHTML = `
            ${task.title} - ${task.description} 
            <button onclick="deleteTask(${task.id})">Delete</button>
        `;
        taskList.appendChild(li);
    });
}

// Attach functions to window for HTML access
(window as any).addNewTask = addNewTask;
(window as any).deleteTask = deleteTask;
//In order to window - use the command - tsc task.ts --target es6
