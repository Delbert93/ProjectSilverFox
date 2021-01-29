import React, { Component } from "react";
import { Input, Button } from "antd";
import "antd/dist/antd.css";

const DEFAULT_STATE = {
  // user: { ...new UserModel() },
};
export class Home extends Component {
  state = {
    ...DEFAULT_STATE,
    username: "",
    password: "",
  };
  static displayName = Home.name;

  passwordChange(e) {
    this.setState({
      password: e.target.value,
    });
  }

  render() {
    return (
      <div>
        <Input
          placeholder="UserName"
          value={this.state.username}
          // onChange={this.setState({})}
        />
        <Input
          placeholder="Password"
          value={this.state.password}
          onChange={this.passwordChange}
        />
        <Button onClick={null}>Login</Button>
      </div>
    );
  }
}
