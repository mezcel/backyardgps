window.onload = function () {
    'use strict';
    var datum_counter = -1; //initialize counter for the Datum Logs

    document.getElementById("locationViewFocus").onclick = function () {
        //resestNavView();
        enlargeLocationView();

        //eraseText('latitude'); //clear the text in the div
        //lat();
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

        datum_counter = datum_counter + 1;
        //datumHistory(datum_counter); //enter in log
        logButtonPress(datum_counter)
        
        
    };
};

function enlargeLocationView() {
    'use strict';
    var col1class, col2class, col3class;
    /*
    col2class = document.getElementsByClassName("col1");
    col2class[0].style.display = 'none';

    col3class = document.getElementsByClassName("col3");
    col3class[0].style.display = 'none';

    col1class = document.getElementsByClassName("col2");
    col1class[0].style.left = '66%';
    col1class[0].style.width = '100%';
    */

    col2class = GEBCN("col1");
    col2class[0].style.display = 'none';

    col3class = GEBCN("col3");
    col3class[0].style.display = 'none';

    col1class = GEBCN("col2");
    col1class[0].style.left = '66%';
    col1class[0].style.width = '100%';

    document.getElementById("serial_info_main").style.width = '100%';
}

function enlargeMetaView() {
    'use strict';
    var col1class, col2class, col3class;
    /*
    col2class = document.getElementsByClassName("col2");
    col2class[0].style.display = 'none';

    col3class = document.getElementsByClassName("col3");
    col3class[0].style.display = 'none';

    col1class = document.getElementsByClassName("col1");
    col1class[0].style.left = '66%';
    col1class[0].style.width = '100%';
    */
    
    col2class = GEBCN("col2");
    col2class[0].style.display = 'none';

    col3class = GEBCN("col3");
    col3class[0].style.display = 'none';

    col1class = GEBCN("col1");
    col1class[0].style.left = '66%';
    col1class[0].style.width = '100%';
    
    document.getElementById("serial_info_meta").style.width = '100%';
}

function enlargeLogView() {
    'use strict';
    var col1class, col2class, col3class;
    /*
    col2class = document.getElementsByClassName("col1");
    col2class[0].style.display = 'none';

    col3class = document.getElementsByClassName("col2");
    col3class[0].style.display = 'none';

    col1class = document.getElementsByClassName("col3");
    col1class[0].style.left = '66%';
    col1class[0].style.width = '100%';
    */
    col2class = GEBCN("col1");
    col2class[0].style.display = 'none';

    col3class = GEBCN("col2");
    col3class[0].style.display = 'none';

    col1class = GEBCN("col3");
    col1class[0].style.left = '66%';
    col1class[0].style.width = '100%';
    document.getElementById("waypoint_log").style.width = '100%';
}

function enlargeCelestialView() {
    'use strict';
    var col1class, col2class, col3class;
    /*
    col1class = document.getElementsByClassName("col1");
    col1class[0].style.display = 'none';

    col2class = document.getElementsByClassName("col2");
    col2class[0].style.display = 'none';

    col3class = document.getElementsByClassName("col3");
    col3class[0].style.display = 'none';
    */
    col1class = GEBCN("col1");
    col1class[0].style.display = 'none';

    col2class = GEBCN("col2");
    col2class[0].style.display = 'none';

    col3class = GEBCN("col3");
    col3class[0].style.display = 'none';
    
}

function resestNavView() {
    'use strict';
    var col1class, col2class, col3class;

    //location
    // col2class = document.getElementsByClassName("col2");
    col2class = GEBCN("col2");
    col2class[0].style.display = 'block';
    col2class[0].style.position = 'relative';
    col2class[0].style.overflow = 'hidden';
    col2class[0].style.float = 'left';
    col2class[0].style.width = '32%';
    col2class[0].style.left = '36%';

    //document.getElementById("serial_info_main").style.width = '';

    //meta
    // col1class = document.getElementsByClassName("col1");
    col1class = GEBCN("col1");
    col1class[0].style.display = 'block';
    col1class[0].style.position = 'relative';
    col1class[0].style.overflow = 'hidden';
    col1class[0].style.float = 'left';
    col1class[0].style.width = '31%';
    col1class[0].style.left = '101%';


    //document.getElementById("serial_info_meta").style.width = '';

    //log
    // col3class = document.getElementsByClassName("col3");
    col3class = GEBCN("col3");
    col3class[0].style.display = 'block';
    col3class[0].style.position = 'relative';
    col3class[0].style.overflow = 'hidden';
    col3class[0].style.float = 'left';
    col3class[0].style.width = '31%';
    col3class[0].style.left = '71%';


    //document.getElementById("waypoint_log").style.width = '';
}

/* text related functions */
function logButtonPress(datum_counter) {
    'use strict';
    var lat, lon;
    
    lat = document.getElementById('latitudeDiv').innerText;
    lon = document.getElementById('longitudeDiv').innerText;
    datumHistory(lat, lon, datum_counter);
}

function datumHistory(latInput, lonInput, datum_counter) {
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
    datumNo.id = "datum" + datum_counter.toString();

    lat = document.createElement("dd");
    lat.id = "lat" + datum_counter.toString();

    lon = document.createElement("dd");
    lon.id = "lon" + datum_counter.toString();

    //family values

    mark.innerHTML = "Marker#:" + datum_counter.toString();
    datumNo.innerHTML = datum_counter.toString() + ": datum";
    lat.innerHTML = datum_counter.toString() + "lat: " + latInput;
    lon.innerHTML = datum_counter.toString() + "lon: " + lonInput;

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

    document.getElementById("latitude").appendChild(para);
}

function eraseText(elementID) {
    'use strict';
    document.getElementById(elementID).innerHTML = "";
}

// VB.Net/IE8-ish Workarround

function GEBCN(cn) {
    'use strict';
    
    if (document.getElementsByClassName) // Returns NodeList here
        return document.getElementsByClassName(cn);

    cn = cn.replace(/ *$/, '');

    if (document.querySelectorAll) // Returns NodeList here
        return document.querySelectorAll((' ' + cn).replace(/ +/g, '.'));

    cn = cn.replace(/^ */, '');

    var classes = cn.split(/ +/), clength = classes.length;
    var els = document.getElementsByTagName('*'), elength = els.length;
    var results = [];
    var i, j, match;

    for (i = 0; i < elength; i++) {
        match = true;
        for (j = clength; j--;)
            if (!RegExp(' ' + classes[j] + ' ').test(' ' + els[i].className + ' '))
                match = false;
        if (match)
            results.push(els[i]);
    }

    // Returns Array here
    return results;
    /* 
    http://stackoverflow.com/questions/9568969/getelementsbyclassname-ie8-object-doesnt-support-this-property-or-method 
    this is because inferior versions of IE would not let me interface with HTML via JS and VisualStudio if this conversion of class/function isn't cosmetically put to correct for syntax
    basically, I can not use getElementsByClassName in VS12 unless I change my default browser which also involves shady registry changes... and that adds inconsistence to my Debug/troubleshooting mindset for other apps i am working on with my Dev PC
    
    replace 
    document.getElementsByClassName("class name")
    with
    GEBCN("class name")
    */
}