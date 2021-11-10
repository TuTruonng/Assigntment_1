import React, { useState, useEffect } from "react";
import { Formik, useFormik } from "formik";
import { withRouter } from "react-router-dom";
import history from "../../Helpers/Help";
import './BDS.css';
import BatDongSanService from "../../Services/BatDongSanService";
import LoaiBatDongSanService from "../../Services/LoaiBatDongSanService";

const BDSForm = ({ match }) => {

  const [realEstateID, setRealEstateID] = useState(match.params.id);
  const [RealEstate, setRealEstate] = useState({});
  const [img, setImg] = useState("");
  const [isCreate, setIsCreate] = useState(match.params.id === undefined ? true : false);
  const [loading, setLoading] = useState(false);

  useEffect(() => {
    async function fetchdata() {
      setRealEstateID(match.params.id);
      console.log("NewsID", realEstateID);
      if (realEstateID !== undefined) {
        await fetchRealEstate(realEstateID);
      }
    }

    fetchdata();
  }, [match.params.id]);

  console.log("OK", RealEstate);

  const formik = useFormik({
    enableReinitialize: true,
    initialValues: {
      categoryid: RealEstate.categoryid,
      userid: RealEstate.userid,
      categoryname: RealEstate.categoryname,
      reportid: RealEstate.reportID,
      title: RealEstate.title,
      price: RealEstate.price,
      image: RealEstate.image,
      description: RealEstate.description,
      acgreage: RealEstate.acgreage,
      slug: RealEstate.slug,
      approve: RealEstate.approve,
      createtime: RealEstate.createtime,
      updatetime: RealEstate.updatetime,
      status: RealEstate.status,
      phongnumber: RealEstate.phoneNumber,
      location: RealEstate.location,
    }
    ,
    onSubmit: async (values) => {
      let result = window.confirm("Are you sure?");
      console.log("get value",values);
      console.log(img);
      if (result) {
        if (isCreate) {
            console.log("Created", values);
          await BatDongSanService.create( (values));
          console.log("Get_Created", values);
          history.goBack();
        } else {
          console.log("values edit", values);
          await BatDongSanService.edit(realEstateID, (values));
          history.goBack();
        }
      }
    },
  });


  const fetchRealEstate = async (itemId) => {
    console.log(BatDongSanService.get(itemId));
    setRealEstate(await (await BatDongSanService.get(itemId)).data);
  };

    const uploadImage = async (e) => {
      const files = e.target.files;
      const data = new FormData();
      data.append("file", files[0]);
      data.append("upload_preset", "Source");
      setLoading(true);
      console.log("acb",loading);
      const res = await fetch(
      " https://api.cloudinary.com/v1_1/dusq8k6rj/image/upload",
        {
          method: "POST",
          body: data,
        }
      );
      const file = await res.json();
      setImg(file.secure_url);
      setLoading(false);
      console.log("data",file.secure_url); 
      if (isCreate) {
        formik.values.image =file.secure_url;
      }
      else {
        formik.values.image = file.secure_url;
      }
    };

  const changeFormikValuestoFormData = (valueForm) => {
    const formSubmitDataLocal = new FormData();
    formSubmitDataLocal.append('newsName', valueForm.newsName);
    formSubmitDataLocal.append('description', valueForm.description);
    formSubmitDataLocal.append('imageRequest', valueForm.imageRequest);
    console.log("FormData", formSubmitDataLocal);
    return formSubmitDataLocal;
  }

  console.log("run", formik.initialValues);

  return (
    <div class="content-wrapper" className="form">
      <h3>Bất Động Sản</h3>
      <br />
      <form onSubmit={formik.handleSubmit}>
        <div className="form-group">
          <label htmlFor="categoryid" className="text">CategoryID</label>
          <input className="input-form"
            id="categoryid"
            name="categoryid"
            type="text"
            {...formik.getFieldProps('categoryid')}
            defaultValue={formik.values.categoryid}
          />
        </div>
        <div className="form-group">
          <label htmlFor="userid" className="text">userID</label>
          <input className="input-form"
            id="userid"
            name="userid"
            type="text"
            {...formik.getFieldProps('userid')}
            defaultValue={formik.values.userid}
          />
        </div>

        <div className="form-group">
          <label htmlFor="categoryname" className="text">CategoryName</label>     
          <input className="input-form"
            id="categoryname"
            name="categoryname"
            type="text"
            {...formik.getFieldProps('categoryname')}
            defaultValue={formik.values.categoryname}
          /> 
        </div>
        <div className="form-group">
          <label htmlFor="reportid" className="text">ReportID</label>
          <input className="input-form"
            id="reportid"
            name="reportid"
            type="text"
            {...formik.getFieldProps('reportid')}
            defaultValue={formik.values.reportid}
          />
        </div>

        <div className="form-group">
          <label htmlFor="title" className="text">Title</label>
          <input className="input-form"
            id="title"
            name="title"
            type="text"
            {...formik.getFieldProps('title')}
            defaultValue={formik.values.title}
          />
        </div>

        <div className="form-group">
          <label htmlFor="price" className="text">Price</label>
          <input className="input-form"
            id="price"
            name="price"
            type="text"
            {...formik.getFieldProps('price')}
            defaultValue={formik.values.price}
          />
        </div>

        <div className="form-group">
          <label htmlFor="image" className="text">Image</label>
          <input className="input-form"
            id="image"
            name="image"
            type="text"
            {...formik.getFieldProps('image')}
            defaultValue={formik.values.image}
          />
        </div>

        <div className="form-group">
          <label htmlFor="description" className="text">description</label>
          <input className="input-form"
            id="description"
            name="description"
            type="text"
            {...formik.getFieldProps('description')}
            defaultValue={formik.values.description}
          />
        </div>

        <div className="form-group">
          <label htmlFor="acgreage" className="text">Acgreage</label>
          <input className="input-form"
            id="acgreage"
            name="acgreage"
            type="text"
            {...formik.getFieldProps('acgreage')}
            defaultValue={formik.values.acgreage}
          />
        </div>

        <div className="form-group">
          <label htmlFor="slug" className="text">Slug</label>
          <input className="input-form"
            id="slug"
            name="slug"
            type="text"
            {...formik.getFieldProps('slug')}
            defaultValue={formik.values.slug}
          />
        </div>

        <div className="form-group">
          <label htmlFor="approve" className="text">Approve</label>
          <input className="input-form"
            id="approve"
            name="approve"
            type="text"
            {...formik.getFieldProps('approve')}
            defaultValue={formik.values.approve}
          />
        </div>

        <div className="form-group">
          <label htmlFor="createtime" className="text">Createtime</label>
          <input className="input-form"
            id="createtime"
            name="createtime"
            type="text"
            {...formik.getFieldProps('createtime')}
            defaultValue={formik.values.createtime}
          />
        </div>

        <div className="form-group">
          <label htmlFor="updatetime" className="text">Updatetime</label>
          <input className="input-form"
            id="updatetime"
            name="updatetime"
            type="text"
            {...formik.getFieldProps('updatetime')}
            defaultValue={formik.values.updatetime}
          />
        </div>

        <div className="form-group">
          <label htmlFor="status" className="text">Status</label>
          <input className="input-form"
            id="status"
            name="status"
            type="text"
            {...formik.getFieldProps('status')}
            defaultValue={formik.values.status}
          />
        </div>

        <div className="form-group">
          <label htmlFor="phongnumber" className="text">PhoneNumber</label>
          <input className="input-form"
            id="phongnumber"
            name="phongnumber"
            type="text"
            {...formik.getFieldProps('phongnumber')}
            defaultValue={formik.values.phongnumber}
          />
        </div>

        <div className="form-group">
          <label htmlFor="location" className="text">Location</label>
          <input className="input-form"
            id="location"
            name="location"
            type="text"
            {...formik.getFieldProps('location')}
            defaultValue={formik.values.updatetime}
          />
        </div>


        <button type="submit" className="button">Submit</button>

      </form>
    </div>
  );
};

export default withRouter(BDSForm);

