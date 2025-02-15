import { Component } from "react";
import { Container,Form,FormControl,Button,ListGroup } from "react-bootstrap";

export class TodoApp extends Component {
    state = {
      tasks: [],
      task: "",
    };
  
    addTask = () => {
      if (this.state.task.trim() === "") return;
      this.setState((prevState) => ({
        tasks: [...prevState.tasks, { id: Date.now(), text: prevState.task, completed: false }],
        task: "",
      }));
    };
  
    toggleComplete = (id) => {
      this.setState((prevState) => ({
        tasks: prevState.tasks.map((t) => (t.id === id ? { ...t, completed: !t.completed } : t)),
      }));
    };
  
    deleteTask = (id) => {
      this.setState((prevState) => ({
        tasks: prevState.tasks.filter((t) => t.id !== id),
      }));
    };
  
    handleChange = (e) => {
      this.setState({ task: e.target.value });
    };
  
    render() {
      return (
        <Container className="mt-4 p-4" style={{ backgroundColor: "#f8f9fa", borderRadius: "10px" }}>
          <h2 className="text-center">Todo List</h2>
          <Form className="d-flex mb-3">
            <Form.Control
              type="text"
              value={this.state.task}
              onChange={this.handleChange}
              placeholder="Add a new task..."
            />
            <Button onClick={this.addTask} variant="primary" className="ms-2">
              Add
            </Button>
          </Form>
          <ListGroup>
            {this.state.tasks.map((t) => (
              <ListGroup.Item
                key={t.id}
                className={`d-flex justify-content-between align-items-center ${
                  t.completed ? "text-decoration-line-through text-muted" : ""
                }`}
              >
                <span onClick={() => this.toggleComplete(t.id)} className="cursor-pointer">
                  {t.text}
                </span>
                <Button onClick={() => this.deleteTask(t.id)} variant="danger" size="sm">
                  Delete
                </Button>
              </ListGroup.Item>
            ))}
          </ListGroup>
        </Container>
      );
    }
  }
  