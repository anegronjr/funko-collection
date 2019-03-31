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

      editOnClick = () => {
          const inputText = document.querySelector(`.input-text${this.props.funkoId}`);
          const saveButton = document.querySelector(`.save-button${this.props.funkoId}`);
          const editButton = document.querySelector(`.edit-button${this.props.funkoId}`);
          const cancelButton = document.querySelector(`.cancel-button${this.props.funkoId}`);
          const deleteButton = document.querySelector(`.delete-button${this.props.funkoId}`);

          inputText.style.display = "inline-block";
          saveButton.style.display = "inline-block";
          cancelButton.style.display = "inline-block";
          editButton.style.display = "none";
          deleteButton.style.display = "none";
      };

      resetDisplay = () => {
        const inputText = document.querySelector(`.input-text${this.props.funkoId}`);
        const saveButton = document.querySelector(`.save-button${this.props.funkoId}`);
        const editButton = document.querySelector(`.edit-button${this.props.funkoId}`);
        const cancelButton = document.querySelector(`.cancel-button${this.props.funkoId}`);
        const deleteButton = document.querySelector(`.delete-button${this.props.funkoId}`);

        inputText.style.display = "none";
        saveButton.style.display = "none";
        cancelButton.style.display = "none";
        deleteButton.style.display = "inline-block";
        editButton.style.display = "inline-block";
      };

    render() {
        const { imgPath, funkoName, funkoId, funkoText } = this.props;

        return (
        <div className="funko">
            <img src={imgPath} />
            <span>{funkoName}</span>
            <input className={`input-text${this.props.funkoId}`} type="text" value={funkoText} onChange={this.props.funkoNameChange} />
            <div className="buttons">
            <button className={`edit edit-button${this.props.funkoId}`} onClick={this.editOnClick}>Edit</button>
            <button className={`save-button${this.props.funkoId} save`} onClick={this.saveChanges}>Save Changes</button>
            <button className={`cancel cancel-button${this.props.funkoId}`} onClick={this.resetDisplay}>Cancel</button>
            <button className={`delete-button${this.props.funkoId}`} onClick={() => this.deleteFunko(funkoId)}>Delete</button>
            </div>
        </div>
        );
    }
}

export default Funko;