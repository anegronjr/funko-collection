import React, { Component } from 'react';

class Funko extends Component {

    deleteFunko = id => {
        const url = "https://localhost:44384/api/funko/" + id;
        fetch(url, {
            method: "DELETE",
            headers: {
                "Content-type": "application/json"
            }
        })
        .then(res => {
            if (res.ok) {
                console.log("yo");
            }
        })
        .catch(err => {
            console.error(err);
        });
      };

      saveChanges = () => {
          this.props.updateFunko(this.props.funkoId, this.props.categoryId, this.props.imgPath);
      }

    render() {
        const { imgPath, funkoName, funkoId, funkoText } = this.props;

        return (
        <div className="funko">
            <img src={imgPath} />
            <span>{funkoName}</span>
            <input type="text" value={funkoText} onChange={this.props.funkoNameChange} />
            <div className="buttons">
            <button>Edit</button>
            <button onClick={this.saveChanges}>Save Changes</button>
            <button onClick={() => this.deleteFunko(funkoId)}>Delete</button>
            </div>
        </div>
        );
    }
}

export default Funko;