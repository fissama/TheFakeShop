import React, { useState, useEffect } from "react";
import { useFormik } from "formik";
import { withRouter,useParams } from "react-router-dom";
import CategoryService from "../../services/CategoryService";

const CategorySubmitForm = ({match}) => {
  const [Category, setCategory] = useState({});
  const formik = useFormik({
    initialValues: {
      CategoryName: '',
      ParentId: ''
    },
    onSubmit: (values) => {
      alert(JSON.stringify(values, null, 2));
    },
  });

  useEffect(() => {
    fetchCategory(match.params.id);
    formik.values.CategoryName=Category.categoryName;
    formik.values.ParentId=Category.parentId;
  }, [match.params.id]);
  console.log(Category);

  const fetchCategory = (itemId) => {
    if(itemId !== undefined){
    CategoryService.get(itemId).then(({ data }) => {
      setCategory(data);
    });
  }
  };
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
