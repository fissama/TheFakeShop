import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import { Table, Button } from "reactstrap";
import ProductService from "../../services/ProductService";

const ListCategory = () => {
  const [Products, setProducts] = useState([]);
  useEffect(() => {
    fetchProduct();
  }, []);

  const fetchProduct = () => {
    ProductService.getList().then(({ data }) => {
      setProducts(data);
    });
  };

  console.log(Products);
  //delete and update view
  const handleDelete = (itemId) => {
    let result = window.confirm("Delete this product?");
    console.log(itemId);
    if (result) {
      ProductService.delete(itemId).then(() => {
        setProducts(Products.filter((item) => item.productId !== itemId));
      });
    }
  };

  return (
    <div>
      <Table>
        <thead>
          <tr>
            <th>STT</th>
            <th>Product Name</th>
            <th>Price</th>
            <th>Image</th>
            <th className="text-right">
              <Link to={`/modifiedProduct/`} >
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
          {Products.map(function (item, i) {
            return (
              <tr>
                <th scope="row">{i}</th>
                <td>{item.productName.substr(0,50).concat("...")}</td>
                <td>{item.price}</td>
                <td>
                    <img src={item.productImages[0]} style={{height:"100px"}} alt="product-ne" />
                    {console.log(item.productImages[0])}
                </td>
                <td className="text-right">
                  <Link to={`/modifiedProduct/${item.productId}`} >
                    <Button //onClick={() => onEdit && onEdit(item)}
                      color="link"
                    >
                      Edit
                    </Button>
                  </Link>
                  
                  <Button
                    onClick={() => handleDelete(item.productId)}
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
