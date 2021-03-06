/* CSS RESET */


html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed, 
figure, figcaption, footer, header, hgroup, 
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
  margin: 0;
	padding: 0;
	border: 0;
	font-size: 100%;
	font: inherit;
	vertical-align: baseline;
}


/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure, 
footer, header, hgroup, menu, nav, section {
	display: block;
}
body {
	line-height: 1;
	
}
ol, ul {
	list-style: none;
}
blockquote, q {
	quotes: none;
}
blockquote:before, blockquote:after,
q:before, q:after {
	content: '';
	content: none;
}
table {
	border-collapse: collapse;
	border-spacing: 0;
}


/* HTML5 tags */
header, section,footer, aside, nav, article{
	display: block;
}



/**** Global ****/


/***** Layout *****/
.body {	/* instead of using div wrapper - body class of my website to be for a certain width (960px) */ 
	clear: both;
	margin: 0 auto;
	width: 960px;
	
}
.bg{
	background: #border: solid 1px red;
	background: #CCC;
}

/* Header */
/*
#banner{
	margin: 0 auto;
	padding: 2.5em 0 0 0;
	clear: left;
	background: #F00;
	width: 500px;
}
*/
header{
/* background: red; */
	background: #537C9E;
	clear: both;
	float: right; 
	width: 960px;
}

/* Body */

body{
	/* background: #ccc; */
	background: #537c9e;
	color: #204E74;
	font-size: 87.5%;  /* Based on font size 14px */
	font-family: arial, Helvetica;
	line-height: 1.429;
	margin: 0 auto;
	padding: 0;
	text-align: left;
	
}

/* Headings */

h1{
	font-size: 1.571em; /* 22px */
	background: #60C9C2;
	width: 550px;
	height: 30px;
	padding: 15px 0 0 25px;
	letter-spacing: 1px;
}
h2{
	font-size: 1.429em; /* 20px */
	color: #60c9c2;
	letter-spacing: 1px;
	margin: 0 0 0 25px;
}
h3{
	font-size: 1em; /* 14px */
}

h1, h2, h3{
	font-weight: 700;
	line-height: 1.1;
	margin-bottom: .8em;
}


/* Anchors */

a{
	outline: 0;
}
a img{
	border: 0px;
	text-decoration: none;
}
a:link, a:visited{
	color: #537C9E;
	padding: 0 1px;
}
a:hover, a:active{
	background-color:  #9DADBA; /*greyish */
	/* height: 50px; */
	/* padding: 15px; */
	color: #fff;
	text-decoration: none;
	text-shadow: 1px 1px 1px #333;  /* shadow on our text that’s 1px to the right, 1px down and with a 1px blur */
}


/* Paragraphs */

p{
	margin: 0 0 1.143em 25px;
	
	
}
p:last-child{
	margin-bottom: 0; /* to avoid large vertical gaps. */
}
::-moz-section{ 		/* CSS3 selector that lets us style how the text selection looks. */
	background: #F6CF74; /* ::-moz-selection needs to go here since Mozilla haven’t implemented the	*/				
	color: #fff; 		
}
::selection{	/* ::selection selector. */
	background: #F6F74;
	color: fff;
}


/* Lists */

ul{
	list-style: outside disc;
	margin:  1em 0 1.5em 1.5em;
}

ol{
	list-style:  outside decimal;
	margin:  1em 0 1.5em 1.5em
}
dl{
	margin: 0 0 1.5em 0;
}
dt{
	font-weight: bold;
}
dd{
	margin-left: 1.5em;
}


/* Quotes */

blockquote{
	font-style: italic;
}

/* Tables */
table {
	margin: .5em auto 1.5em auto; 
	width: 98%;
}
 
/* Thead */
thead th {
	padding: .5em .4em; 
	text-align: left;
}
thead td {}
 
/* Tbody */
tbody td {
	padding: .5em .4em;
}
tbody th {
	
}
tbody .alt td {
	
}
tbody .alt th {
	
}

/* Tfoot */
tfoot th {
	
}
tfoot td {
	
}


/* END GLOBAL CSS SETTINGS */





/* HOME PAGE */

/* GlobalNav2 */
html{
	/* border: solid cyan 1px; */
	background: #537C9E;
	
}
#mainNav2{
	background: #60C9C2;
	font-size: 14px;
	font-family: arial;
	font-weight: bold;
	height: 40px;
	width: 294px;
	float: right;
	clear: left;
	margin: 0 0 0px 0;
	/* border: solid 1px red; */
	
	
}
#mainNav2 li{
	/* clear: both; */
	float: left;
	list-style: none;
	
}
#mainNav2 li:first-child{ /* internal medicine */
	clear: both;
	float: left;
	margin: 0 -20px 0 -30px;
	width: 200px;
	padding: 0 0 0 8px;
}
#mainNav2 li a{
	text-decoration: none;
	padding: 16px 16px 8px 15px;
}

/* GlobalNav */ 
#wrapper{
	background: #CCC;
	width: 960px;
	margin: 0 0 0 700px;
}
#logo{
	/* margin: 0px 20px 0px -62px; */
	background: #537C9E;
	clear: left;
	float: left;
	width: 272.25px;
	margin: 20px 0 -20px 0;
	
}

#mainNav{
	background: #CCC;
	font-size: 14px;
	font-family: arial;
	font-weight: bold;
	height: 40px;
	width: 685px;
	float: right;
	clear: both;
	margin: 0 0px 0 0;
	position: relative;
	/* border: solid 1px red; */
	
}

#mainNav li{
	float: left;
	list-style: none;
}
#mainNav li a{
	text-decoration: none;
	padding: 16px 16px 8px 15px;
}

article{
	background: #CCC;
	clear: left;
	float: left;
	
}

article p{
	/* width: 245px; */
	clear: left;
	/* overflow: hidden; */
	/* border: solid 1px red; */
	
}
article h1{
	width: 625px;
	margin: 21px 0 0 0;
}
#generalContent{
	width: 540px;
	background: #CCC;
}
#generalContent p{
	width: 245px;
}
#newsletter{
	/* border: solid 1px blue; */
	width: 245px;
	margin: 40px 0 50px 0px;
}
#newsletter p{
	clear: left;
	float: left;
	width: 245px;
	/* margin: 0 0 0 -1px; */
}


#missionStatement{
	/* border: solid 1px blue; */
	float: left;
	clear: left;
	width: 245px;
	margin: -200px 0 50px 300px;
	
}
#missionStatement p{
	clear: left;
	float: left;
	width: 245px;
	display: block;
	/* margin: 0 0 0 -1px; */

	
}
#whatsNew{
	clear: left;
	float: left;
	width: 245px;
	margin: 0 0 0 -1px;
	/* border: solid 1px blue; */
}
#patientPortal{
	clear: left;
	float: left;
	width: 245px;
	/* border: solid 1px blue; */
	margin: -195px  0 0 300px;
	

}
#patientPortal p span{
	/* border: solid 1px blue; */
	margin: -35px 0 0 150px;
	font-size: 10px;
	float: left;
	clear: left;
	
}
#portal{
	margin: 0 0 0px 50px;
	/* border: solid 1px blue; */
	clear: left;
	float: left;

}

#contact{
	/* border: solid 1px green; */
	width: 240px;
	clear: left;
	float: right;
	margin: -645px 42px 0 694px;
}
#contact h1{
	/*
clear: left;
	float: left;
*/
	width: 240px;
	margin: 0 50px 0 0;
}
#OC{
	background: #60C9C2;
	padding: 5px 0 5px 18px;
	margin: 10px 0 10px 25px;
	width: 200px;
}
#Deland{
	background: #60C9C2;
	padding: 5px 0 5px 18px;
	margin: 10px 0 10px 25px;
	width: 200px;
}
#contact p{
	/* border: solid 1px green; */
	margin: 0 60px 0 45px; 
	
	
}
#contactBg{
	background: #9DADBA;
	width: 265px;
	clear: left;
	float: left;
	margin: 25px 0 0 0;
	padding: 0 0 20px 0;
}
#contact p span{
	/* border: solid 1px green; */
	font-weight: bold;
	
}
.getMap{
	font-size: 11px;
	
}
.getMap a{
	text-decoration: none;
}
#facebookIcon{
	/* border: solid 1px green; */
	clear: left;
	float: left;
	margin: 0 0 0 221px;
}
footer{
	clear: left;
	float: left;
}
#nav1 li a{
	color: #5fc9c2;
	margin: 0 0 0 700px;
	clear: left;
	float: left;
	border: solid 1px green;
	width: 70px;
	list-style: none;
	text-decoration: none;
}
#nav2 li a{
	color: #5fc9c2;
	margin: 0 0 0 820px;
	clear: left;
	float: left;
	border: solid 1px green;
}
