import React, { Component } from "react";
import { Input, Button } from "antd";
import "antd/dist/antd.css";
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
  }

  render() {
    return (
      <div>
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
      </div>
    );
  }
}
