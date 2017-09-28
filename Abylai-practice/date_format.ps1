<#The target of this exercise is to create a string, an integer, and a complex variable using command substitution. The string should be named BIRTHDATE and should contain the text "Jan 1 2000". The integer should be named Presents and should contain the number 10. The complex variable should be named BIRTHDAY and should contain the full weekday name of the day matching the date in variable BIRTHDATE e.g. Saturday.#>

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
$BIRTHDAY = [datetime]::ParseExact($BIRTHDATE, 'dd.MM.yyyy', $null)
Write-Output $BIRTHDAY

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