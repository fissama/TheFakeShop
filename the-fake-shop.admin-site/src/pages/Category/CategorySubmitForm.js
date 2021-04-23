import React, { useState, useEffect } from "react";
import { useFormik } from "formik";
import { withRouter } from "react-router-dom";
import CategoryService from "../../services/CategoryService";
import { LIST_CATEGORY } from '../../constants/page';
import { Link } from 'react-router-dom';
import history from '../../helpers/history';


const CategorySubmitForm = ({ match }) => {
  const [categoryId, setCategoryId] = useState(match.params.id);
  const [Category, setCategory] = useState({});
  const formik = useFormik({
    enableReinitialize: true,
    initialValues: {
      name: Category.categoryName,
      parentId: Category.parentId,
    },
    onSubmit: async (values) => {
      let result = window.confirm("Are you sure?");
      console.log(values);
      if (result) {
        let isCreate = categoryId === undefined ? true : false;
        console.log(isCreate);
        if (isCreate) {
          await CategoryService.create(values);
          history.goBack();
        } else {
          await CategoryService.edit(categoryId, values);
          history.goBack();
        }
      }
    },
  });

  useEffect(() => {
    async function fetchdate() {
      setCategoryId(match.params.id);
      console.log(categoryId);
      if (categoryId !== undefined) {
        await fetchCategory(categoryId);
        console.log(formik.initialValues);
      } else {
      }
    }
    fetchdate();
  }, [match.params.id]);

  const fetchCategory = async (itemId) => {
    console.log(CategoryService.get(itemId));
    setCategory(await (await CategoryService.get(itemId)).data);
  };
  console.log(Category);

  return (
    <form onSubmit={formik.handleSubmit}>
      <label htmlFor="name">Category Name</label>
      <input
        id="name"
        name="name"
        type="text"
        onChange={formik.handleChange}
        value={formik.values.name}
      />
      <label htmlFor="parentId">Parent Id</label>
      <input
        id="parentId"
        name="parentId"
        type="number"
        onChange={formik.handleChange}
        value={formik.values.parentId}
      />
        <button type="submit">Submit</button>
    </form>
  );
};

export default withRouter(CategorySubmitForm);
