import React, { useState, useEffect } from "react";
import { Formik, useFormik } from "formik";
import { withRouter } from "react-router-dom";
import ProductService from "../../services/ProductService";
import history from "../../helpers/history";

const CategorySubmitForm = ({ match }) => {
  const [productId, setProductId] = useState(match.params.id);
  const [Product, setProduct] = useState({});
  const [image, setImage] = useState("");
  const [isCreate,setIsCreate] = useState(match.params.id===undefined?true:false);
  const [loading, setLoading] = useState(false);
  useEffect(() => {
    async function fetchdata() {
      setProductId(match.params.id);
      console.log(productId);
      if (productId !== undefined) {
        await fetchProduct(productId);
      }

      console.log("is creazzzz",isCreate);
    }
    fetchdata();
  }, [match.params.id]);

  const formik = useFormik({
    enableReinitialize:true,
    initialValues: {
      name: Product.productName,
      price: Product.price,
      description: Product.description,
      instock: Product.inStock,
      categoryId: Product.categoryId,
      images: Product.productImages===undefined?[]:[...Product.productImages],
      
    }
    ,
    onSubmit: async (values) => {
      let result = window.confirm("Are you sure?");
      //values.images.push(image);
      console.log("values ne");
      console.log(values);
      if(!isCreate){
          values.images = [];
          values.images.push(image);
          console.log("values edit", values);
      }
      if (result) {
        if (isCreate) {
          await ProductService.create(changeFormikValuestoFormData(values));
          history.goBack();
        } else {
          //values.images = [...image];
          console.log("values edit", values);
          await ProductService.edit(productId, values);
          history.goBack();
        }
      }
    },
  });
  console.log("run zzzz",formik.initialValues);
  const fetchProduct = async (itemId) => {
    console.log(ProductService.get(itemId));
    setProduct(await (await ProductService.get(itemId)).data);
  };

  const changeFormikValuestoFormData = (valueForm)=>{
    const formSubmitDataLocal= new FormData();
    formSubmitDataLocal.append('name',valueForm.name);
    formSubmitDataLocal.append('price',valueForm.price);
    formSubmitDataLocal.append('description',valueForm.description);
    formSubmitDataLocal.append('instock',valueForm.instock);
    formSubmitDataLocal.append('categoryId',valueForm.categoryId);
    formSubmitDataLocal.append('images',[...valueForm.images]);
    console.log("demo");
    console.log(formSubmitDataLocal);
    return formSubmitDataLocal;
  }
 
  const uploadImage = async (e) => {
    const files = e.target.files;
    const data = new FormData();
    data.append("file", files[0]);
    data.append("upload_preset", "fissama");
    setLoading(true);
    const res = await fetch(
      "https://api.cloudinary.com/v1_1/fissama/image/upload",
      {
        method: "POST",
        body: data,
      }
    );
    const file = await res.json();
    setImage(file.secure_url);
    setLoading(false);
    //formik.values.images.push(file.secure_url);
    console.log("is create",isCreate);
    console.log("image",image);
    if(isCreate){
    formik.values.images = [...formik.values.images,file.secure_url];
    }
    else {
      formik.values.images = [];
      formik.values.images=[...formik.values.images,image];
    }
  };
  return (
    <form onSubmit={formik.handleSubmit}>
      <div className="form-group">
        <label htmlFor="name">Product Name</label>
        <input
          id="name"
          name="name"
          className="form-control"
          type="textarea"
          {...formik.getFieldProps('name')}
          value={formik.values.name}
        />
      </div>
      <div className="form-group row">
        <div className="form-group col">
          <label htmlFor="price">Price</label>
          <input
            id="price"
            name="price"
            type="number"
            {...formik.getFieldProps('price')}
            value={formik.values.price}
          />
        </div>
        <div className="form-group col">
          <label htmlFor="instock">InStock</label>
          <input
            id="instock"
            name="instock"
            type="number"
            {...formik.getFieldProps('instock')}
            value={formik.values.instock}
          />
        </div>
        <div className="form-group col">
          <label htmlFor="categoryId">Category Id</label>
          <input
            id="categoryId"
            name="categoryId"
            type="number"
            {...formik.getFieldProps('categoryId')}
            value={formik.values.categoryId}
          />
        </div>
      </div>
      <div className="form-group">
        <label htmlFor="description">Description</label>
        <input
          id="description"
          name="description"
          type="textarea"
          className="form-control"
          {...formik.getFieldProps('description')}
          value={formik.values.description}
        />
      </div>
      <div className="form-group">
        <label htmlFor="images">Upload Image</label>
        <input
          type="file"
          id="images"
          name="images"
          placeholder="Upload an image"
          onChange={uploadImage}
          style={{ display: "block" }}
        />
        {
          loading ? (
            <h3>Loading...</h3>
          ) : (
            <img src={image} style={{ width: "100px" }} alt="product-image" />
          )
        }
      </div>
      <button type="submit">Submit</button>
    </form>
  );
};

export default withRouter(CategorySubmitForm);
