var masterDivContents = ""; //avariable containing all the div contents

window.onload = function () {
    'use strict';
    var datum_counter = -1; //initialize counter for the Datum Logs

    document.getElementById("locationViewFocus").onclick = function () {
        resestNavView();
        enlargeLocationView();
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
        var tableHtmlString, formatting_string;
        
        formatting_string = "<!-- to convert this list to a table ( Delete the <dl> tag and replace it with: <table> ) and (Replace each <li> tag with table row and table data tags: <tr><td> ) and close each of the elements --> <style>/* Table Printout Format */table {font-family: arial, sans-serif; border-collapse: collapse; width: 100%; } td, th { border: 1px solid #dddddd; text-align: left; padding: 8px; } tr:nth-child(even) { background-color: #dddddd; }</style>";
        
        masterDivContents = masterDivContents + "</DIV>";
        
        tableHtmlString = convertListToTable(masterDivContents, datum_counter); //convert from list html to table html
        masterDivContents = tableHtmlString + formatting_string;
        saveHtmlAsFile(); //used for any browser
        
        
        //SaveContents(); //just for IE
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

function watchForLostSignal() {
    
}
/* process text related functions */

function logButtonPress(datum_counter) {
    'use strict';
    var lat, lon;
    
    lat = document.getElementById('latitude_GPGGA').innerText;
    lon = document.getElementById('longitude_GPGGA').innerText;
    datumHistory(lat, lon, datum_counter);
    
    // masterDivContents += " " + document.getElementById("waypoint_log").innerHTML;
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
    datumNo.id = "Datum" + datum_counter.toString();
    datum_text = document.createTextNode("Datum: " + datum_counter.toString());
    datumNo.appendChild(datum_text);
    

    lat = document.createElement("li");
    lat.id = "lat" + datum_counter.toString();
    lat_text = document.createTextNode(latInput);
    lat.appendChild(lat_text);

    lon = document.createElement("li");
    lon.id = "lon" + datum_counter.toString();
    lon_text = document.createTextNode(lonInput);
    lon.appendChild(lon_text);
    
    
    mark.appendChild(datumNo);
    datumNo.appendChild(lat);
    datumNo.appendChild(lon);

    
    //LILO
    if (datum_counter > 0) {
        node_temp = (datum_counter - 1).toString();
        node_temp = "datum" + node_temp;
        
        previusDatum = document.getElementById(node_temp);
        mark.parentNode.insertBefore(previusDatum, mark.nextSibling);
    }
    
}

/* savine to a file **********************/

function convertListToTable(inputString, datum_counter) {
    'use strict';
    var i, cycleRepeat, headerString;
	
	headerString = "id=logDatumHistory><tr><th>Latitude</th><th>Longitude</th></tr>";
    cycleRepeat = datum_counter * 2; //more or less, typicall 1 is not enough, this was overkill, but absolute
    
    inputString = inputString.replace(/<DIV/g, "<table");  
    inputString = inputString.replace(/<\/DIV>/g,"</table>");

    inputString = inputString.replace(/<DL/g, "<tr");  
    inputString = inputString.replace(/<\/DL>/g,"</tr>"); 

    inputString = inputString.replace(/<LI/g, "<td");  
    inputString = inputString.replace(/<\/LI>/g,"</td>"); 

    //http://stackoverflow.com/questions/20779071/how-to-find-and-replace-text-in-between-two-tags-in-html-or-xml-document-using-j
    // do this a few time just to catch the few times something was missed
    for (i = 0; i < cycleRepeat; i++) { 
        inputString = inputString.replace(/<tr[\s\S]*?<td/, '<tr> <td'); // the 1st tr
        inputString = inputString.replace(/<\/tr><tr[\s\S]*?<td/, '<tr> <td'); // the rest of the tr's
        inputString = inputString.replace(/>\r\n[\s\S]*?<td/, '> <td'); // the exception tr
        inputString = inputString.replace(/<\/tr><tr[\s\S]*?\r\n<td/, '<tr> <td'); // trs with line break
        inputString = inputString.replace(/<\/table>\r\n<tr[\s\S]*?<td/, '\r\n<td'); // that first table end
    }
    
	inputString = inputString.replace(/id=logDatumHistory>/g, headerString);
	
    return inputString;
}

function SaveContents() {
    /* intended for IE8 */
    'use strict';
    var oWin, success;
    
    if (document.execCommand) {
        
        oWin = window.open("about:blank", "_blank");
        //To add a new line, you need to use <br>
        oWin.document.writeln(masterDivContents); //convert from list html to table html);
        oWin.document.close();
        
        //Need to specify the filename that we are going to set here
        success = oWin.document.execCommand('SaveAs', true, "output.html")
        
        oWin.close();
        if (!success) { /* do nothing */}
    }
}

function saveHtmlAsFile() {
    'use strict';
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
        fileNameToSaveAs = "output.html";
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
    
    var lostsignalCheck;
    
    date = new Date();
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
        
        // every 10 seconds, check if I still have a usable signal
        lostsignalCheck = document.getElementById('latitude_GPGGA').innerText;
        
        if (lostsignalCheck === "N/A") {
            document.getElementsByTagName('body')[0].style.backgroundColor = "red";
        } else {
            document.getElementsByTagName('body')[0].style.backgroundColor = "green";
        }
        
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
