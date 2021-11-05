import React, { Component,  useEffect } from 'react';
import { UserContext } from "../index";
import AuthService from "../Services/AuthService";
import { USER_PROFILE_STORAGE_KEY } from "../Constants/oidc_config";
import { Link } from 'react-router-dom';


export default class Navbar extends Component {
  state = {
    username: undefined,
  };

  handleLogin = (e) => {
    console.log("abc");
    AuthService.loginAsync();
    
  }

  handleLogout = (e) => {
    AuthService.logoutAsync();
  }

  componentDidMount() {
    let userStorageValue = localStorage.getItem(USER_PROFILE_STORAGE_KEY);
    let user = JSON.parse(userStorageValue);
    if (user !== undefined) {
      this.setState({
        username: user?.name
      })
    }
  }

  render() {
    return (
      <UserContext.Consumer>
        {(value) => (
          <aside className="main-sidebar sidebar-dark-primary elevation-4">
            {/* <!-- Brand Logo --> */}
            <a href="/" className="brand-link">

              <span className="brand-text font-weight-light" >Bất Động Sản </span>

            </a>
            <div className="sidebar">
              {/* <!-- Sidebar user panel (optional) --> */}
              <div className="user-panel mt-3 pb-3 mb-3 d-flex">
                <div className="info">
                  <img src="https://vnwriter.net/wp-content/uploads/2017/05/emotion-2.jpg" style={{ height: "100%", width: "100%", backgroundColor: "yellow" }}></img>
                </div>
              </div>

              {/* <!-- SidebarSearch Form --> */}
              <div className="form-inline">
                <div className="input-group" data-widget="sidebar-search">
                </div>
              </div>

              <nav className="mt-2">
                <ul className="nav nav-pills nav-sidebar flex-column" data-widget="treeview" role="menu" data-accordion="false" style={{ textAlign: "left" }}>
                  <li className="nav-item">
                    <a href="/loaibatdongsan" className="nav-link">
                      <i class="fas fa-sitemap"></i>
                      <p>
                        &nbsp;
                        Loại Bất Động Sản
                      </p>
                    </a>
                  </li>
                  <li className="nav-item">
                    <a href="/batdongsan" className="nav-link">
                      <i className="fas fa-list-ol"></i>
                      <p>
                        &nbsp;
                        Bất Động Sản
                      </p>
                    </a>
                  </li>
                  <li className="nav-item">
                    <a href="/khachhang" className="nav-link">
                      <i class="fas fa-user-friends"></i>
                      <p>
                        &nbsp;
                        Khách hàng
                      </p>
                    </a>
                  </li>
                  <li className="nav-item">
                    <a href="/nhanvien" className="nav-link">
                      <i class="fas fa-user-tie"></i>
                      <p>
                        &nbsp;
                        Nhân viên
                      </p>
                    </a>
                  </li>
                  <li className="nav-item">
                    <a href="/nhanvien" className="nav-link">
                      <i class="fas fa-hand-holding-usd"></i>
                      <p>
                        &nbsp;
                        Lương Nhân viên
                      </p>
                    </a>
                  </li>

                  <li className="nav-item">
                    <a href="/tintuc" className="nav-link">
                      <i class="fas fa-desktop"></i>
                      <p>
                        &nbsp;
                        Tin Tức
                      </p>
                    </a>
                  </li>
                  <li className="nav-item">
                    <a href="/baocao" className="nav-link">
                      <i class="fas fa-list-alt"></i>
                      <p>
                        &nbsp;
                        Báo cáo
                      </p>
                    </a>
                  </li>
                </ul>

                <input type="text" onChange={(e) => this.props.onSearchKey(e)} />

                <div className="nav-details">
                  <p className="nav-username"> {this.state.username} </p>
                </div>

                {(this.state.username === undefined) ? (
                  <button
                    className="btn btn-danger"
                    type="button"
                    onClick={(e) => this.handleLogin(e)}>
                    Login
                  </button>
                ) : (
                  <button
                    className="btn btn-danger"
                    type="button"
                    onClick={(e) => this.handleLogout(e)}>
                    Logout
                  </button>
                )}
              </nav>
            </div>
          </aside>
        )}
      </UserContext.Consumer>
    )
  }
}