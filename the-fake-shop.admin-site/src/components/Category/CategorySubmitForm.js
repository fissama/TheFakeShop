import React, { useState, useEffect } from "react";
import { useFormik } from "formik";
import { withRouter } from "react-router-dom";
import CategoryService from "../../services/CategoryService";

const CategorySubmitForm = ({ match }) => {
  const [Category, setCategory] = useState({});
  useEffect(() => {
    fetchCategory(match.params.id);
  }, [match.params.id]);

  console.log(match.params.id)
  const fetchCategory = (itemId) => {
    CategoryService.get(itemId).then(({ data }) => {
      setCategory(data);
    });
  };

  const formik = useFormik({
    initialValues: {
      CategoryName: Category === null ? '' : Category.categoryName,
      ParentId: Category === null ? '' : Category.parentId,
    },
    onSubmit: (values) => {
      alert(JSON.stringify(values, null, 2));
    },
  });
  return (
    <form onSubmit={formik.handleSubmit}>
      <label htmlFor="CategoryName">Category Name</label>
      <input
        id="CategoryName"
        name="CategoryName"
        type="text"
        onChange={formik.handleChange}
        value={formik.values.CategoryName}
      />
      <label htmlFor="ParentId">Parent Id</label>
      <input
        id="ParentId"
        name="ParentId"
        type="number"
        onChange={formik.handleChange}
        value={formik.values.ParentId}
      />
      <button type="submit">Submit</button>
    </form>
  );
};

export default withRouter(CategorySubmitForm);
