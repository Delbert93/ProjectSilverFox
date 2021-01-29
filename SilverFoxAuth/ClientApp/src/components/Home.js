import React, { Component } from "react";
import { Input, Button, Card } from "antd";
import "antd/dist/antd.css";
import axios from "axios";
import "../CSS/Login.css";
// import UserModel from "../../../Models/UserModel";

const DEFAULT_STATE = {
  username: "",
  password: "",
};
export class Home extends Component {
  state = {
    ...DEFAULT_STATE,
  };
  static displayName = Home.name;

  passwordChange(e) {
    this.setState({
      password: e.target.value,
    });
  }

  loginClick() {
    // let user = new UserModel(this.state.username, this.state.password);
    //TO DO
    //check origin and syntax
    //package info
    //send to api
    axios.get("LOGIN_API").then((res) => {
      const isValidUser = res.status;
      this.setState({ isValidUser });
    });
  }

  registerClick() {
    axios.post("REGISTER_API").then((res) => {
      const persons = res.data;
      this.setState({ persons });
    });
  }

  render() {
    return (
      <Card title="Login" style={{ width: "400px" }}>
        <Input
          placeholder="UserName"
          value={this.state.username}
          onChange={() => this.setState({ username: this.value })}
        />
        <Input
          placeholder="Password"
          value={this.state.password}
          onChange={() => this.setState({ password: this.value })}
          type="password"
        />
        <Button onClick={this.loginClick}>Login</Button>
        <Button onClick={this.registerClick}>Register</Button>
      </Card>
    );
  }
}
