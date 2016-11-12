window.onload = function () {
    'use strict';
    var logcounter = -1;
    
    document.getElementById("locationViewFocus").onclick = function () {
        resestNavView();
        enlargeLocationView();
        
        //eraseText('latitude'); //clear the text in the div
        lat();
    };
    
    document.getElementById("metaViewFocus").onclick = function () {
        resestNavView();
        enlargeMetaView();
    };
    
    document.getElementById("logViewFocus").onclick = function () {
        resestNavView();
        enlargeLogView();
        
    };
    
    document.getElementById("celestialViewFocus").onclick = function () {
        resestNavView();
        enlargeCelestialView();
    };
    
    document.getElementById("allViewFocus").onclick = function () {
        resestNavView();
    };
    
    document.getElementById("logButton").onclick = function () {
        
        var inputstring;
        
        logcounter = logcounter + 1;
        inputstring = logcounter;
        datumHistory(inputstring); //enter in log
    };
};

function enlargeLocationView() {
    'use strict';
    var col1class, col2class, col3class;
    
    col2class = document.getElementsByClassName("col1");
    col2class[0].style.display = 'none';
    
    col3class = document.getElementsByClassName("col3");
    col3class[0].style.display = 'none';
    
    col1class = document.getElementsByClassName("col2");
    col1class[0].style.left = '66%';
    col1class[0].style.width = '100%';
    
    document.getElementById("serial_info_main").style.width = '100%';
}

function enlargeMetaView() {
    'use strict';
    var col1class, col2class, col3class;
    
    col2class = document.getElementsByClassName("col2");
    col2class[0].style.display = 'none';
    
    col3class = document.getElementsByClassName("col3");
    col3class[0].style.display = 'none';
    
    col1class = document.getElementsByClassName("col1");
    col1class[0].style.left = '66%';
    col1class[0].style.width = '100%';
    
    document.getElementById("serial_info_meta").style.width = '100%';
}

function enlargeLogView() {
    'use strict';
    var col1class, col2class, col3class;
    
    col2class = document.getElementsByClassName("col1");
    col2class[0].style.display = 'none';
    
    col3class = document.getElementsByClassName("col2");
    col3class[0].style.display = 'none';
    
    col1class = document.getElementsByClassName("col3");
    col1class[0].style.left = '66%';
    col1class[0].style.width = '100%';
    
    document.getElementById("waypoint_log").style.width = '100%';
}

function enlargeCelestialView() {
    'use strict';
    var col1class, col2class, col3class;
    
    col1class = document.getElementsByClassName("col1");
    col1class[0].style.display = 'none';
    
    col2class = document.getElementsByClassName("col2");
    col2class[0].style.display = 'none';
    
    col3class = document.getElementsByClassName("col3");
    col3class[0].style.display = 'none';
}

function resestNavView() {
    'use strict';
    var col1class, col2class, col3class;
    
    //location
    col2class = document.getElementsByClassName("col2");
    col2class[0].style.display = 'block';
    col2class[0].style.position = 'relative';
    col2class[0].style.overflow = 'hidden';
    col2class[0].style.float = 'left';
    col2class[0].style.width = '32%';
    col2class[0].style.left = '36%';
    
   //document.getElementById("serial_info_main").style.width = '';
    
    //meta
    col1class = document.getElementsByClassName("col1");
    col1class[0].style.display = 'block';
    col1class[0].style.position = 'relative';
    col1class[0].style.overflow = 'hidden';
    col1class[0].style.float = 'left';
    col1class[0].style.width = '31%';
    col1class[0].style.left = '101%';
    
    
    //document.getElementById("serial_info_meta").style.width = '';
    
    //log
    col3class = document.getElementsByClassName("col3");
    col3class[0].style.display = 'block';
    col3class[0].style.position = 'relative';
    col3class[0].style.overflow = 'hidden';
    col3class[0].style.float = 'left';
    col3class[0].style.width = '31%';
    col3class[0].style.left = '71%';
    
    
    //document.getElementById("waypoint_log").style.width = '';
}

/* text related functions */

function datumHistory(inputstring) {
    /* 
        http://stackoverflow.com/questions/7258185/javascript-append-child-after-element 
        https://developer.mozilla.org/en-US/docs/Web/API/Node/appendChild
        https://developer.mozilla.org/en-US/docs/Web/API/Node/insertBefore
        https://developer.mozilla.org/en-US/docs/Web/API/Node/innerText
        http://www.w3schools.com/html/tryit.asp?filename=tryhtml_lists_description
    */
    
    'use strict';
    var mark, datumNo, lat, lon;
    
    //name family
    
    mark = document.getElementById("logDatumHistory");
    
    datumNo = document.createElement("dl");
    datumNo.id = "datum"+inputstring.toString();
    
    lat = document.createElement("dd");
    lat.id = "lat" + inputstring.toString();
    
    lon = document.createElement("dd");
    lon.id = "lon" + inputstring.toString();
    
    //family values
    
    mark.innerHTML = "Marker#:" + inputstring.toString();    
    datumNo.innerHTML = inputstring.toString() + ": datum";
    lat.innerHTML = inputstring.toString() + ": lat";
    lon.innerHTML = inputstring.toString() + ": lon";
    
    // inherit family
    
    mark.parentNode.appendChild(datumNo); //inherit
    datumNo.parentNode.appendChild(lat); //inherit
    datumNo.parentNode.appendChild(lon); //inherit
    
    //display family
    
    datumNo.parentNode.insertBefore(datumNo, mark.nextSibling);
    lon.parentNode.insertBefore(lon, datumNo.nextSibling);
    lat.parentNode.insertBefore(lat, datumNo.nextSibling);
    
}

function lat() {
    'use strict';
    var para, t;
    
    para = document.createElement("div");
    t = document.createTextNode("This is a paragraph.");
    para.appendChild(t);
    
    if (para.style.color != 'red') {
        para.style.color = 'blue';
    } else if (para.style.color === 'blue') {
        para.style.color = 'red';
    }
    
    document.getElementById("latitude").appendChild(para);
}

function eraseText(elementID) {
    document.getElementById(elementID).innerHTML = "";
}