<#The script was taken from exercise http://www.learnshell.org/en/Variables #>

<#BASH script#>

<#
BIRTHDATE=
Presents=
BIRTHDAY=


# Testing code - do not change it

if [ "$BIRTHDATE" == "Jan 1 2000" ] ; then
    echo "BIRTHDATE is correct, it is $BIRTHDATE"
else
    echo "BIRTHDATE is incorrect - please retry"
fi
if [ $Presents == 10 ] ; then
    echo "I have received $Presents presents"
else
    echo "Presents is incorrect - please retry"
fi
if [ "$BIRTHDAY" == "Saturday" ] ; then
    echo "I was born on a $BIRTHDAY"
else
    echo "BIRTHDAY is incorrect - please retry"
fi
#>

$BIRTHDATE = '01.01.2000'
$Presents = 10
$BIRTHDAY = [datetime]::ParseExact($BIRTHDATE, 'dd.MM.yyyy', $null) <#Parsing datetime from string#>
Write-Output $BIRTHDAY <#output for check up the correctness of parsing#>
 
<#outputs with conditions#>
if($BIRTHDATE = "01.01.2000"){
    "BIRTHDATE is correct, it is $BIRTHDATE"
}
else{
    "BIRTHDATE is incorrect - please retry"}

if ($Presents = 10 ){ 
    "I have received $Presents presents"
    }
else{
    "Presents is incorrect - please retry"
}

if ($BIRTHDAY = "Saturday" ){ 
    "I was born on a $BIRTHDAY"
    }
else{
    "BIRTHDAY is incorrect - please retry"
}