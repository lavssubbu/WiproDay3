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
    }

    deleteTask(id: number): void {
        const index = this.tasks.findIndex(t => t.id === id);
        if (index === -1) {
            console.log(`Error: Task with ID ${id} does not exist.`);
            return;
        }
        this.tasks.splice(index, 1);
        console.log(`Task deleted successfully.`);
    }
}

// Testing the TaskManager class
const manager = new TaskManager();

// Adding tasks
manager.addTask({ id: 1, title: "Complete Assignment", description: "Finish TypeScript assignment", completed: false });
manager.addTask({ id: 2, title: "Read Book", description: "Read 20 pages of a book", completed: false });

// Viewing tasks
console.log("Tasks:", manager.viewTasks());

// Modifying a task
manager.modifyTask(1, { completed: true });

// Deleting a task
manager.deleteTask(2);

// Attempting to delete a non-existent task
manager.deleteTask(3);
