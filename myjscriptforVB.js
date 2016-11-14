var masterDivContents = ""; //avariable containing all the div contents

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

        datum_counter = datum_counter + 1;
        logButtonPress(datum_counter);
        
    };
    
    document.getElementById("saveDatumList").onclick = function () {
        
        masterDivContents = masterDivContents + "</DIV>";
        masterDivContents = masterDivContents + " <!-- to convert this list to a table (Delete the <ul> tag and replace it with: <table>) and (Replace each <li> tag with table row and table data tags: <tr><td> ) and close each of the elements -->";
        
        saveTextAsFile();
        //SaveContents();
    };
    
    date_time('date_time');
};

/* display related */

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

/* process text related functions */

function logButtonPress(datum_counter) {
    'use strict';
    var lat, lon;
    
    lat = document.getElementById('latitudeDiv').innerText;
    lon = document.getElementById('longitudeDiv').innerText;
    datumHistory(lat, lon, datum_counter);
    
    masterDivContents = document.getElementById("waypoint_log").innerHTML;
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
    var mark, previusDatum, datumNo, datum_text, lat, lat_text, lon, lon_text, node, node_temp;

    mark = document.getElementById("logDatumHistory");

    datumNo = document.createElement("dl");
    datumNo.id = "datum" + datum_counter.toString();
    datum_text= document.createTextNode("datum" + datum_counter.toString());
    datumNo.appendChild(datum_text);
    

    lat = document.createElement("li");
    lat.id = "lat" + datum_counter.toString();
    lat_text = document.createTextNode(datum_counter.toString() + "lat: " + latInput);
    lat.appendChild(lat_text);

    lon = document.createElement("li");
    lon.id = "lon" + datum_counter.toString();
    lon_text = document.createTextNode(datum_counter.toString() + "lon: " + lonInput);
    lon.appendChild(lon_text);
    
    mark.appendChild(datumNo);
    datumNo.appendChild(lon);
    datumNo.appendChild(lat);
    
    //LILO
    if (datum_counter > 0) {
        node_temp = (datum_counter - 1).toString();
        node_temp = "datum" + node_temp;
        
        previusDatum = document.getElementById(node_temp);
        mark.parentNode.insertBefore(previusDatum, mark.nextSibling);
    }
    
}

/* savine to a file **********************/

function SaveContents() {
    /* intended for IE8 */
    'use strict';
    if (document.execCommand) {
        
        var oWin = window.open("about:blank", "_blank");
        //To add a new line, you need to use <br>
        oWin.document.writeln(masterDivContents);
        oWin.document.close();

        //Need to specify the filename that we are going to set here
        var success = oWin.document.execCommand('SaveAs', true, "output.txt")


        oWin.close();
        if (!success) {}
    }
}

function saveTextAsFile() {
    /* https://jsfiddle.net/nekyouto/gokpfr00/ */
    var fileNameToSaveAs, downloadLink, textFileAsBlob, textToWrite;
    
    //For Blobs, use \r\n for new line
    textToWrite = masterDivContents; //pulled from my global var
    
    //Check if browser supports Blob
    if (window.Blob) {
        textFileAsBlob = new Blob([textToWrite], {
            type: 'text/plain'
        });
        
        //Need to specify the filename that we are going to set here
        fileNameToSaveAs = "output.txt";
        downloadLink = document.createElement("a");
        downloadLink.download = fileNameToSaveAs;
        downloadLink.innerHTML = "Download File";
        if (window.webkitURL != null) {
            // Chrome allows the link to be clicked without actually adding it to the DOM.
            downloadLink.href = window.webkitURL.createObjectURL(textFileAsBlob);
        } else {
            // Firefox requires the link to be added to the DOM before it can be clicked.
            downloadLink.href = window.URL.createObjectURL(textFileAsBlob);
            downloadLink.onclick = destroyClickedElement;
            downloadLink.style.display = "none";
            document.body.appendChild(downloadLink);
        }
        
        if (navigator.msSaveBlob) {
            navigator.msSaveBlob(textFileAsBlob, fileNameToSaveAs);
        } else {
            downloadLink.click();
        }
        
    } else {
        /* Error/Solution Catch: used for IE8 */
        SaveContents();
    }
}

//Remove the downloadable link
function destroyClickedElement(event) {
    document.body.removeChild(event.target);
}

/*****************************************/


/* TIme Display */
function date_time(id) {
    date = new Date;
    year = date.getFullYear();
    month = date.getMonth();
    months = new Array('January', 'February', 'March', 'April', 'May', 'June', 'Jully', 'August', 'September', 'October', 'November', 'December');

    d = date.getDate();
    day = date.getDay();
    days = new Array('Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday');
    h = date.getHours();

    if (h < 10) {
        h = "0" + h;
    }

    m = date.getMinutes();

    if (m < 10) {
        m = "0" + m;
    }

    s = date.getSeconds();

    if (s < 10) {
        s = "0" + s;
    }

    result = ' ' + days[day] + ' ' + months[month] + ' ' + d + ' ' + year + ' ' + h + ':' + m + ':' + s;
    document.getElementById(id).innerHTML = result;
    setTimeout('date_time("' + id + '");', '1000');

    return true;
}


function eraseText(elementID) {
    'use strict';
    document.getElementById(elementID).innerHTML = "";
}

// VB.Net/IE8-ish Workarround

function GEBCN(cn) {
    'use strict';
    var classes, els, results, i, j, match;
    
    // Returns NodeList here
    if (document.getElementsByClassName) {
        return document.getElementsByClassName(cn);
    }
    
    cn = cn.replace(/ *$/, '');

    // Returns NodeList here
    if (document.querySelectorAll) {
        return document.querySelectorAll((' ' + cn).replace(/ +/g, '.'));
    }
    
    cn = cn.replace(/^ */, '');

    classes = cn.split(/ +/), clength = classes.length;
    els = document.getElementsByTagName('*'), elength = els.length;
    results = [];

    for (i = 0; i < elength; i++) {
        match = true;
        for (j = clength; j--;) {
            if (!RegExp(' ' + classes[j] + ' ').test(' ' + els[i].className + ' ')) {
                match = false;
            }
        }
        
        if (match) {
            results.push(els[i]);
        }
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
