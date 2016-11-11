window.onload = function () {
    'use strict';
    var thisButtonIDIsPushed;
    
    thisButtonIDIsPushed = document.getElementById('articleLocationStatus');
    
    document.getElementById('locationStatusButton').onclick = function () {
        toggleGpsGroupVisibility('articleLocationStatus', 'articleMetaInformation', 'articleWaypointLog');
    };
    
    document.getElementById('metaInformationButton').onclick = function () {
        toggleGpsGroupVisibility('articleMetaInformation', 'articleLocationStatus', 'articleWaypointLog');
        
    };
    
    document.getElementById('waypointLogButton').onclick = function () {
        toggleGpsGroupVisibility('articleWaypointLog', 'articleLocationStatus', 'articleMetaInformation');
    };
    
};

function toggGpsleVisibility(id) {
    'use strict';
    var e = document.getElementById(id);
    
    if (e.style.display === 'block') {
        e.style.display = 'none';
    } else {
        e.style.display = 'block';
    }
    e.style.width = '';
}

function toggleGpsGroupVisibility(stayVisible, hide1, hide2) {
    'use strict';
    var e1, e2, e3;
    e1 = document.getElementById(stayVisible);
    e2 = document.getElementById(hide1);
    e3 = document.getElementById(hide2);
    
    //toggGpsleVisibility(hide1);
    //toggGpsleVisibility(hide2);
    
    if ( (e2.style.display === 'block') || (e3.style.display === 'block') ) {
        //hide
        e2.style.display = 'none';
        e3.style.display = 'none';
        //show
        e1.style.display = 'block';
        e1.style.width = '100%';
    } else {
        //show all
        e2.style.display = 'block';
        e2.style.width = '';
        
        e3.style.display = 'block';
        e3.style.width = '';
        
        e1.style.display = 'block';
        e1.style.width = '';
        
        //document.getElementById(stayVisible).style.display = 'block';
        //document.getElementById(stayVisible).style.width = '100%';
    }
}