import "./App.css";
import { Route, Switch } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css";

//Components
import Navbar from "./components/Navbar";
import { UserList } from "./components/UserList";
import { UserForm } from "./components/UserForm";

function App() {
  return (
    <div>
      <Navbar />
      <Switch>
        <Route path="/" component={UserList} exact></Route>
        <Route path="/form" component={UserForm}></Route>
        <Route path="/edit" component={UserForm}></Route>
      </Switch>
    </div>
  );
}

export default App;
