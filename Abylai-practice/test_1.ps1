$number = Read-Host -Prompt 'Please enter a number: ' <# input a number from keyboard #>
if ($number -gt 0 -and $number -lt 14) { <# if a number great than 0 and less than 14  output > "I have a card"#>
    Write-Host "I have a card"
}
else { <# if a number out of diapason 0-14 output will "There is no such card"#>
    Write-Host "There is no such card"
}