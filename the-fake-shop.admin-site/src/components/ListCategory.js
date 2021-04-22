import React, { useState, useEffect } from "react";
import { Table, Button } from "reactstrap";
import CategoryService from "../services/CategoryService";

const ListCategory = () => {
  const [Categories, setCategories] = useState([]);
  useEffect(() => {
    fetchCategory();
  }, []);

  const fetchCategory = () => {
    CategoryService.getList().then(({ data }) => setCategories(data));
  };
  return (
    <div>
      <Table>
        <thead>
          <tr>
            <th>STT</th>
            <th>Category Name</th>
            <th>Parent Category</th>
          </tr>
        </thead>
        <tbody>
          {Categories.map(function (item, i) {
            return (
              <tr>
                <th scope="row">{i}</th>
                <td>{item.categoryName}</td>
                <td>{item.parentId}</td>
                <td className="text-right">
                  <Button //onClick={() => onEdit && onEdit(item)}
                    color="link"
                  >
                    Edit
                  </Button>
                  <Button
                    //onClick={() => onDelete && onDelete(item.Id)}
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
