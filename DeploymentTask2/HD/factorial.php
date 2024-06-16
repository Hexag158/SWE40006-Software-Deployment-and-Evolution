<!DOCTYPE html>
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<meta name="description" content="" />
<meta name="keywords" content="Web,programming" />
<meta name="Nghia" content="103806269">
<title>Using if and while statements</title>
</head>
<body>
    <?php
        include ("mathfunctions.php");
    ?>
        <h1>Find The Factorial</h1>
    <?php
        if (isset ($_GET["number"])) 
        { 
            $num = $_GET["number"]; // obtain the form data
            if ($num >= 0) { // check if $num is a positive number
                if ($num == round ($num)) { // check if $num is an integer
                    echo "<p>", $num, "! is ", factorial ($num), ".</p>";
                } 
                else { // number is not an integer
                    echo "<p>Please enter an integer.</p>";
                }
            } 
            else { // number is not positive
                echo "<p>Please enter a  integer. </p>";
            }
        } 
        else { // no input
            echo "<p>Please enter a number .</p>";
        }
    ?>
</body>
</html>