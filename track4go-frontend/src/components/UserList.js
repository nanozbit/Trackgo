import React, { Component } from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faEdit, faTrashAlt } from "@fortawesome/free-solid-svg-icons";
import axios from "axios";
import { Link } from "react-router-dom";

const url = "http://backend:5001/api/user";
export class UserList extends Component {
  state = {
    data: [],
    user: {
      id_User: "",
      name_User: "",
      identityDocument_User: "",
      telephone_User: "",
      mail_User: "",
    },
  };

  componentDidMount() {
    this.getUser();
  }

  getUser = () => {
    axios
      .get(url)
      .then((response) => {
        this.setState({ data: response.data });
      })
      .catch((error) => {
        console.log(error.message);
      });
  };

  setUser = (user) => {
    this.setState({
      user: {
        id_User: user.id_User,
        name_User: user.name_User,
        identityDocument_User: user.identityDocument_User,
        telephone_User: user.telephone_User,
        mail_User: user.mail_User,
      },
    });
    this.props.history.push({
      pathname: "/form",
      data: this.state.user,
    });
  };

  delete = (user) => {
    console.log(user);
    if (user) {
      axios
        .delete(url,user) 
        .then()
        .catch((error) => {
          console.log(error.message);
        });
    }
  };

  render() {
    return (
      <table className="table">
        <thead>
          <tr>
            <th>ID</th>
            <th>Nombre Usuario</th>
            <th>Cedula</th>
            <th>Telefono</th>
            <th>Email</th>
          </tr>
        </thead>
        <tbody>
          {this.state.data.map((user) => {
            return (
              <tr key="{}">
                <td>{user.id_User}</td>
                <td>{user.name_User}</td>
                <td>{user.telephone_User}</td>
                <td>{user.identityDocument_User}</td>
                <td>{user.mail_User}</td>
                <td>
                  <Link
                    to={{
                      pathname: "/edit",
                      data: user,
                    }}
                  >
                    <button
                      className="btn btn-primary"
                      onClick={() => {
                        this.setUser(user);
                      }}
                    >
                      <FontAwesomeIcon icon={faEdit} />
                    </button>
                  </Link>
                  {"   "}

                  <button
                    className="btn btn-danger"
                    onClick={() => {
                      this.delete(user.id_User);
                    }}
                  >
                    <FontAwesomeIcon icon={faTrashAlt} />
                  </button>
                </td>
              </tr>
            );
          })}
        </tbody>
      </table>
    );
  }
}

export default UserList;
