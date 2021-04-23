import React, { useState, useEffect } from "react";
import { Table, Button } from "reactstrap";
import UserService from "../../services/UserService";

const ListUser = () => {
  const [Users, setUsers] = useState([]);
  useEffect(() => {
    fetchUser();
  }, []);

  const fetchUser = () => {
    UserService.getList().then(({ data }) => {
      setUsers(data);
    });
  };
  console.log(Users);   
  return (
    <div>
      <Table>
        <thead>
          <tr>
            <th>STT</th>
            <th>User Name</th>
            <th>Email</th>
          </tr>
        </thead>
        <tbody>
          {Users.map(function (item, i) {
            return (
              <tr>
                <th scope="row">{i}</th>
                <td>{item.userName}</td>
                <td>{item.email}</td>
                <td className="text-right">
                  <Button //onClick={() => onEdit && onEdit(item)}
                    color="link"
                  >
                    Enable
                  </Button>

                  <Button
                    //onClick={() => handleDelete(item.id)}
                    color="link"
                    className="text-danger"
                  >
                    Block
                  </Button>
                </td>
              </tr>
            );
          })}
        </tbody>
      </Table>
    </div>
  );
};

export default ListUser;
