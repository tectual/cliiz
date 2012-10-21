div.datepicker {
	position: relative;
	font-family: Arial, Helvetica, sans-serif;
	font-size: 12px;
	width: 196px;
	height: 147px;
	position: absolute;
	cursor: default;
	top: 0;
	left: 0;
	display: none;
}
.datepickerContainer {
	background: #121212;
	position: absolute;
	top: 10px;
	left: 10px;
}
.datepickerBorderT {
	position: absolute;
	left: 10px;
	top: 0;
	right: 10px;
	height: 10px;
	background: url(../images/datepicker_t.png);
}
.datepickerBorderB {
	position: absolute;
	left: 10px;
	bottom: 0;
	right: 10px;
	height: 10px;
	background: url(../images/datepicker_b.png);
}
.datepickerBorderL {
	position: absolute;
	left: 0;
	bottom: 10px;
	top: 10px;
	width: 10px;
	background: url(../images/datepicker_l.png);
}
.datepickerBorderR {
	position: absolute;
	right: 0;
	bottom: 10px;
	top: 10px;
	width: 10px;
	background: url(../images/datepicker_r.png);
}
.datepickerBorderTL {
	position: absolute;
	top: 0;
	left: 0;
	width: 10px;
	height: 10px;
	background: url(../images/datepicker_tl.png);
}
.datepickerBorderTR {
	position: absolute;
	top: 0;
	right: 0;
	width: 10px;
	height: 10px;
	background: url(../images/datepicker_tr.png);
}
.datepickerBorderBL {
	position: absolute;
	bottom: 0;
	left: 0;
	width: 10px;
	height: 10px;
	background: url(../images/datepicker_bl.png);
}
.datepickerBorderBR {
	position: absolute;
	bottom: 0;
	right: 0;
	width: 10px;
	height: 10px;
	background: url(../images/datepicker_br.png);
}
.datepickerHidden {
	display: none;
}
div.datepicker table {
	border-collapse:collapse;
}
div.datepicker a {
	color: #eee;
	text-decoration: none;
	cursor: default;
	outline: none;
}
div.datepicker table td {
	text-align: right;
	padding: 0;
	margin: 0;
}
div.datepicker th {
	text-align: center;
	color: #999;
	font-weight: normal;
}
div.datepicker tbody th {
	text-align: left;
}
div.datepicker tbody a {
	display: block;
}
.datepickerDays a {
	width: 20px;
	line-height: 16px;
	height: 16px;
	padding-right: 2px;
}
.datepickerYears a,
.datepickerMonths a{
	width: 44px;
	line-height: 36px;
	height: 36px;
	text-align: center;
}
td.datepickerNotInMonth a {
	color: #666;
}
tbody.datepickerDays td.datepickerSelected{
	background: #136A9F;
}
tbody.datepickerDays td.datepickerNotInMonth.datepickerSelected {
	background: #17384d;
}
tbody.datepickerYears td.datepickerSelected,
tbody.datepickerMonths td.datepickerSelected{
	background: #17384d;
}
div.datepicker a:hover,
div.datepicker a:hover {
	color: #88c5eb;
}
div.datepicker td.datepickerNotInMonth a:hover {
	color: #999;
}
div.datepicker tbody th {
	text-align: left;
}
.datepickerSpace div {
	width: 20px;
}
.datepickerGoNext a,
.datepickerGoPrev a,
.datepickerMonth a {
	text-align: center;
	height: 20px;
	line-height: 20px;
}
.datepickerGoNext a {
	float: right;
	width: 20px;
}
.datepickerGoPrev a {
	float: left;
	width: 20px;
}
table.datepickerViewDays tbody.datepickerMonths,
table.datepickerViewDays tbody.datepickerYears {
	display: none;
}
table.datepickerViewMonths tbody.datepickerDays,
table.datepickerViewMonths tbody.datepickerYears,
table.datepickerViewMonths tr.datepickerDoW {
	display: none;
}
table.datepickerViewYears tbody.datepickerDays,
table.datepickerViewYears tbody.datepickerMonths,
table.datepickerViewYears tr.datepickerDoW {
	display: none;
}
td.datepickerDisabled a,
td.datepickerDisabled.datepickerNotInMonth a{
	color: #333;
}
td.datepickerDisabled a:hover {
	color: #333;
}
td.datepickerSpecial a {
	background: #700;
}
td.datepickerSpecial.datepickerSelected a {
	background: #a00;
}
