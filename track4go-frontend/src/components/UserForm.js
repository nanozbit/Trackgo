import React, { Component } from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import { v4 as uuidv4 } from "uuid";

import axios from "axios";

const url = "http://localhost:15001/api/user";
export class UserForm extends Component {
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
    const { data } = this.props.location;
    const {
      match: { path },
    } = this.props;
    if (path === "/edit") {
      this.setState({ user: data });
    } else {
      const uuid = uuidv4();
      this.setState({ user: { id_User: uuid } });
    }
  }

  handleChange = async (e) => {
    e.persist();
    await this.setState({
      user: {
        ...this.state.user,
        [e.target.name]: e.target.value,
      },
    });
  };

  save = () => {
    const sendData = this.state.user;
    console.log("Data save", sendData);
    if (sendData) {
      axios
        .post(url, sendData, { crossdomain: true } )
        .then(() => {
			window.location.reload();
		})
        .catch((error) => {
          console.log(error.message);
        });
    }
  };

  update = () => {
    const sendData = this.state.user;
    console.log("Data update", sendData);
    if (sendData) {
      axios
        .put(url, sendData,  { crossdomain: true })
        .then(()=> {
			window.location.reload();
		})
        .catch((error) => {
          console.log(error.message);
        });
    }
  };

  insertUser = async () => {
    const {
      match: { path },
    } = await this.props;
    console.log(path);
    if (path === "/edit") {
      await this.update();
    } else {
      await this.save();
    }
    this.props.history.push("/");
  };

  render() {
    return (
      <div className="card d-flex justify-content-center align-item-center">
        <div className="form-group">
          <label htmlFor="id_User">UUID</label>
          <input
            type=""
            className="form-control"
            id="id_User"
            name="id_User"
            onChange={this.handleChange}
            value={this.state.user.id_User}
          />
        </div>
        <div className="form-group">
          <label htmlFor="name_User">Nombre Usuario</label>
          <input
            type="text"
            className="form-control"
            name="name_User"
            onChange={this.handleChange}
            value={this.state.user.name_User}
            id="name_User"
          />
        </div>
        <div className="form-group">
          <label htmlFor="identityDocument_User">Cedula</label>
          <input
            type="text"
            className="form-control"
            name="identityDocument_User"
            onChange={this.handleChange}
            value={this.state.user.identityDocument_User}
            id="identityDocument_User"
          />
        </div>
        <div className="form-group">
          <label htmlFor="telephone_User">Telefono</label>
          <input
            type=""
            className="form-control"
            id="telephone_User"
            name="telephone_User"
            onChange={this.handleChange}
            value={this.state.user.telephone_User}
            placeholder="0912345678"
          />
        </div>
        <div className="form-group">
          <label htmlFor="mail_User">Email</label>
          <input
            type="email"
            className="form-control"
            id="mail_User"
            name="mail_User"
            value={this.state.user.mail_User}
            onChange={this.handleChange}
            placeholder="admin@track4go.com"
          />
        </div>

        <button className="btn btn-primary" onClick={this.insertUser}>
          Save
        </button>
      </div>
    );
  }
}

export default UserForm;
