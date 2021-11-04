import React, { useState, useEffect } from "react";
import { Formik, useFormik } from "formik";
import { withRouter } from "react-router-dom";
import history from "../../Helpers/Help";
import'./BDS.css';
import BatDongSanService from "../../Services/BatDongSanService";

const BDSForm = ({ match }) => {

  const [realEstateID, setRealEstateID] = useState(match.params.id);
  const [RealEstate, setRealEstate] = useState({});
  const [img, setImg] = useState("");
  const [isCreate, setIsCreate] = useState(match.params.id === undefined ? true : false);
  const [loading, setLoading] = useState(false);

  useEffect(() => {
    async function fetchdata() {
      setRealEstateID(match.params.id);
      console.log("NewsID",realEstateID);
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
      approve: RealEstate.approve,
      phoneNumber: RealEstate.phoneNumber,
    }
    ,
    onSubmit: async (values) => {
      let result = window.confirm("Are you sure?");
      console.log("values",values);
      console.log(img);
      if (result) {
        if (isCreate) {
          await BatDongSanService.create( (values));
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

//   const uploadImage = async (e) => {
//     const files = e.target.files;
//     const data = new FormData();
//     data.append("file", files[0]);
//     data.append("upload_preset", "leduyen");
//     setLoading(true);
//     console.log("acb",loading);
//     const res = await fetch(
//     " https://api.cloudinary.com/v1_1/dusq8k6rj/image/upload",
//       {
//         method: "POST",
//         body: data,
//       }
//     );
//     const file = await res.json();
//     setImg(file.secure_url);
//     setLoading(false);
//     console.log("conmeo",img);
//     console.log("conmeo2",file.secure_url); 
//     if (isCreate) {
//       formik.values.img =file.secure_url;
//     }
//     else {
//       formik.values.img = file.secure_url;
//     }
//   };

  const changeFormikValuestoFormData = (valueForm) => {
    const formSubmitDataLocal = new FormData();
    formSubmitDataLocal.append('newsName', valueForm.newsName);
    formSubmitDataLocal.append('description', valueForm.description);
    formSubmitDataLocal.append('imageRequest', valueForm.imageRequest);
    console.log("FormData",formSubmitDataLocal);
    return formSubmitDataLocal;
  }

  console.log("run", formik.initialValues);

  return (
    <div class="content-wrapper"  className="form" style={{width:"1300px", height:"1000px",marginLeft:"300px"}}>
        <h3>Bất Động Sản</h3>
        <br/>
      <form onSubmit={formik.handleSubmit}>
        <div className="form-group">
          <label htmlFor="approve" className="text">approve</label>
          <input className="input-form"
            id="approve"
            name="approve"
            type="text"
           {...formik.getFieldProps('approve')}
           defaultValue={formik.values.approve}
          />
        </div>
        <div className="form-group">
          <label htmlFor="phoneNumber" className="text">UserID</label>
          <input className="input-form"
            id="phoneNumber"
            name="phoneNumber"
            type="text"
             {...formik.getFieldProps('phoneNumber')}
             defaultValue={formik.values.phoneNumber}
          />
        </div>
      
        <button type="submit" className="button">Submit</button>

      </form>
    </div>
  );
};

export default withRouter(BDSForm);

