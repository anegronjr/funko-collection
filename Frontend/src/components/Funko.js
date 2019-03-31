import React, { Component } from 'react';

class Funko extends Component {

    deleteFunko = id => {
        const url = "https://localhost:44384/api/funko/" + id;
        fetch(url, {
            headers: {
                "Content-type": "application/json"
            },
            method: "POST",
            mode: "no-cors"
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

    render() {
        const { imgPath, funkoName, funkoId } = this.props;

        return (
        <div className="funko">
            <img src={imgPath} />
            <span>{funkoName}</span>
            <div className="buttons">
            <button>Edit</button><button onClick={() => this.deleteFunko(funkoId)}>Delete</button>
            </div>
        </div>
        );
    }
}

export default Funko;