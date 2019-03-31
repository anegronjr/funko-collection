import React, { Component } from 'react';

class Funko extends Component {
    render() {
        const { imgPath, funkoName } = this.props;

        return (
        <div className="funko">
            <img src={imgPath} />
            <span>{funkoName}</span>
        </div>
        );
    }
}

export default Funko;