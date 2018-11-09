import {Component} from "react";
import React from "react";
import Typography from "@material-ui/core/Typography/Typography";
import Grid from "@material-ui/core/Grid/Grid";
import Paper from "@material-ui/core/Paper/Paper";

const fbStyle = {
    'width': '600px',
    'overflow': 'auto',
    'textAlign': 'center'
};

const imageStyle = {
    backgroundColor: '#303030',
};

class Home extends Component {
    render() {
        return (
            <div id="home-root">
                <Grid container spacing={24}>
                    <Grid item xs={4}>
                        <Paper elevation={0} style={imageStyle}>
                            <img src="http://www.j-cars.be/images/website2.jpg" title="" alt=""/>
                        </Paper>
                    </Grid>
                    <Grid item xs={4}>
                        <br/>
                        <Paper elevation={0} style={{backgroundColor: '#303030'}}>
                            <Typography variant="headline">
                                <span>Over ons:</span>
                            </Typography>
                            <Typography>
                                <span>Bij ons kan je terecht voor :</span>
                                <ul>
                                    <li>Oldtimers en 2de handswagens</li>
                                    <li>Service (onderhoud)</li>
                                    <li>Alle onderdelen voor luchtgekoelde Volkswagens</li>
                                    <li>Alle herstellingen</li>
                                    <li>Restauraties</li>
                                    <li>Motorrevisie luchtgekoelde vw's</li>
                                </ul>
                            </Typography>
                        </Paper>
                    </Grid>
                    <Grid item xs={4}>
                        <Paper elevation={0} style={imageStyle}>
                            <img src="http://www.j-cars.be/images/20171221_144353.jpg" title="" alt=""/>
                        </Paper>
                    </Grid>
                    <Grid item xs={4}/>
                    <Grid item xs="auto">
                        <div id="fb-element" style={fbStyle}>
                            <div id="fb-root">
                                <script>{(function (d, s, id) {
                                    let js, fjs = d.getElementsByTagName(s)[0];
                                    if (d.getElementById(id)) return;
                                    js = d.createElement(s);
                                    js.id = id;
                                    js.src = 'https://connect.facebook.net/nl_NL/sdk.js#xfbml=1&version=v3.2';
                                    fjs.parentNode.insertBefore(js, fjs);
                                }(document, 'script', 'facebook-jssdk'))}
                                </script>
                            </div>
                            <div className="fb-page" data-href="https://www.facebook.com/J-cars-182615478462501/"
                                 data-tabs="timeline" data-small-header="false" data-adapt-container-width="true"
                                 data-hide-cover="false" data-show-facepile="true">
                                <blockquote cite="https://www.facebook.com/J-cars-182615478462501/"
                                            className="fb-xfbml-parse-ignore"><a
                                    href="https://www.facebook.com/J-cars-182615478462501/">J-cars</a></blockquote>
                            </div>
                        </div>
                    </Grid>

                </Grid>

            </div>
    )
    }
    }

    export default Home;