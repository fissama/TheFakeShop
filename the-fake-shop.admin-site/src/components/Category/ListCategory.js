import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import { Table, Button } from "reactstrap";
import CategoryService from "../../services/CategoryService";

const ListCategory = () => {
  const [Categories, setCategories] = useState([]);
  useEffect(() => {
    fetchCategory();
  }, []);

  const fetchCategory = () => {
    CategoryService.getList().then(({ data }) => {
      setCategories(data);
    });
  };

  //delete and update view
  const handleDelete = (itemId) => {
    let result = window.confirm("Delete this category?");
    if (result) {
      CategoryService.delete(itemId).then(() => {
        setCategories(Categories.filter((item) => item.id !== itemId));
      });
    }
  };

  return (
    <div>
      <Table>
        <thead>
          <tr>
            <th>STT</th>
            <th>Category Name</th>
            <th>Parent Category</th>
            <th className="text-right">
              <Link to={`/modifiedCategory/${0}`} >
                <Button //onClick={() => onEdit && onEdit(item)}
                  color="link"
                  className="text-success"
                >
                  Create
                </Button>
              </Link>
            </th>
          </tr>
        </thead>
        <tbody>
          {Categories.map(function (item, i) {
            return (
              <tr>
                <th scope="row">{i}</th>
                <td>{item.categoryName}</td>
                <td>
                  {item.parentId == null
                    ? item.parentId
                    : Categories.find((x) => x.id === item.parentId)
                        .categoryName}
                </td>
                <td className="text-right">
                  <Button //onClick={() => onEdit && onEdit(item)}
                    color="link"
                  >
                    Edit
                  </Button>
                  <Button
                    onClick={() => handleDelete(item.id)}
                    color="link"
                    className="text-danger"
                  >
                    Remove
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

export default ListCategory;
