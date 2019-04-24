# Representation of a 9 digit code generation

1. 4 digit for customer code, converted into hex no. Add some padding if required 
   (ex: for customer no 1 hex representation is also 1. in that case padding could be addedd in front of it.).
2. 2 digit for store id information converted into hex. 
   Store ID and value information can be saved into any database or in XML format.
   (Need to add some padding if required)
3. 2 digit for date, also converted into hex no. Accomodate max date in only 2 digit in hex conversion.
   (Need to add some padding to make it 2 digit)
4. 1 digit for month, also converted into hex. accomodate max month in only 1 digit in hex conversion.


# Prevent Cheters
1. As we are provide random numbers in dockets so there is no way to guess the original code saved into the
database under this number.
2. Moreover whenever customer enters their data into our website 
then unique code would be checked in the database first whethere that is the forst entry or not.
3. Besides entering email address and unique code they also have to verify captcha to identify 
where he/she is a human or robot.
4. More than 3 attempts from any particular email address will be blocked.

# Easiness for end users to copy/read data
1. to generate random no (against 9 digit code) which will print in the docket we can also generate hex random no which will generate smaller no and will be 
easy to read and copy it into our website. 
(ex: hex representation of 2000000 is 1E8480 which is reasily readable.)
