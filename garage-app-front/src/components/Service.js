import {Component} from "react";
import React from "react";
import Grid from "@material-ui/core/Grid/Grid";
import Paper from "@material-ui/core/Paper/Paper";
import Typography from "@material-ui/core/Typography/Typography";



const imageStyle = {
    backgroundColor: '#303030',
};

class Service extends Component {
    render() {
        return (
            <div id="service-root">
                <Grid container spacing={24}>
                    <Grid item xs={6}>
                        <br/>
                        <Paper elevation={0} style={{backgroundColor: '#303030'}}>
                            <Typography variant="headline">
                                <span>Onderhoud / Herstellingen :</span>
                            </Typography>
                            <Typography>
                                <p>
                                    U kan in onze werkplaats terecht voor onderhoud, alle herstellingen, motorrevisie en laswerken van uw oldtimer/ classic car.
                                    <br/><br/>

                                    Specialiteit luchtgekoelde volkswagen en Porsche.
                                    Alsook met uw jongere VAG wagen helpen wij U verder
                                    <br/> <br/>

                                    Alle apparatuur en gereedschap om uw Volkswagen , Porsche te herstellen en
                                    te onderhouden is voorhanden.
                                    <br/> <br/>

                                    Om zo efficiënt mogelijk te werken is het wenselijk om telefonisch een afspraak te maken.
                                </p>
                            </Typography>
                        </Paper>
                    </Grid>
                    <Grid item xs={6}>
                        <Paper elevation={0} style={imageStyle}>
                            <img src="http://www.j-cars.be/images/20160112_163930.jpg" title="" alt=""/>
                        </Paper>
                    </Grid>
                    <Grid item xs={6}>
                        <br/>
                        <Paper elevation={0} style={{backgroundColor: '#303030'}}>
                            <Typography variant="headline">
                                <span>Shop :</span>
                            </Typography>
                            <Typography>
                                <p>
                                    In onze shop vindt u alle onderdelen en accessoires voor de luchtgekoelde Volkswagens.
                                    <br/><br/>

                                    Wij hebben ook steeds enkele retro/ vintage stuff in voorraad voor uw VW of andere oldtimer.
                                    <br/> <br/>

                                    Alle aangekochte artikelen kunnen wij voor u monteren in onze werkplaats.
                                </p>
                            </Typography>
                        </Paper>
                    </Grid>
                    <Grid item xs={6}>
                        <Paper elevation={0} style={imageStyle}>
                            <img src="http://www.j-cars.be/images/20160302_081124.jpg" title="" alt=""/>
                        </Paper>
                    </Grid>
                </Grid>
            </div>
        )
    }
}

export default Service;