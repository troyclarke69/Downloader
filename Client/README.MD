blazor deployment on Dec 17-18/2020:

On Site launch (initial load):
18.11 MB in resources, 37-42s to load

Resolutions: build a RELEASE \_framework folder by RUNNING from ...\Client folder:

>> dotnet publish --configuration Release

(creates /Release folder under /bin folder)

COMPARISONS:
\Client\bin\DEBUG\netstandard2.1\wwwroot\_framework folder size: 
24.9MB

\Client\bin\RELEASE\netstandard2.1\wwwroot\_framework folder size: 
9.3MB

look at mscorlib.dll -
4191KB v. 1738KB (also contains GZ which are comparible)

* also - geolocation GET 805ms

Redeployed to web-1217
(instead of creating new bucket/cloudformation) ...

1. Change ApiHelper Urls
2. Clean/Rebuild
3. cmd on /Client and run 'dotnet publish --configuration Release'
4. Copy _frameworks folder from Release/... to ... Client/wwwroot/
5. cmd on /Client/wwwroot folder and run 'aws s3 sync . s3://web-<bucket-name>' ie. web-1217
6. Test (after ?? minutes/hours) by clearing history on browser (used firefox)... open console ... clear Network, and then load troyclarke.tk

TEST: 
dotnet watch run

REFERENCE: https://aws.amazon.com/blogs/developer/run-blazor-based-net-web-applications-on-aws-serverless/

DEPLOY:
Copy _framework folder from bin/Debug/netstandard2.1/wwwroot to the wwwroot folder
* Change Dec 18/2020 -- grab _framework under RELEASE folder *

Open Window Command Prompt at this level (Downloader,/Client/wwwroot) run 
aws s3 sync . s3://web-<bucket> command to sync content from this folder to Amazon S3 bucket

Launch an AWS CloudFormation stack from this deep link with existing_s3bucket_with_cloudfront.yamlfile
(DO ON EVERY DEPLOY ?) The verdict: (Dec 18 2020):: ?

USEFUL NOTES ON AWS CLI (Configuration/Permissions, etc):
https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-quickstart.html

ex.
$ aws configure
AWS Access Key ID [None]: <from /downloads>
AWS Secret Access Key [None]: <from /downloads>
Default region name [None]: 
Default output format [None]: json


** 02-09-2021 Deploy:
DEPLOY TO NETLIFY:
1. Change ApiHelper Urls
2. Clean/Rebuild
3. cmd on /Client and run 'dotnet publish --configuration Release'
4. Copy _frameworks folder from Release/... to ... Client/wwwroot/
5. Copy wwwroot folder to Netlify Site
6. Test by clearing history on browser (used firefox)... open console ... clear Network, and then load troyport.netlify.app

-- wwwroot size: 14.3MB 
** took 1:34 to LOAD!! Firefox -- after cache cleared
2nd load (no clear cache): 5.58s
3rd: 3.66s
4th (CLEARED CACHE):

Comparisons:
-- _framework folder SIZE:
-- --Debug: 25.4MB
-- --Release: 13.4MB 


Feb 17 2021
Redeployed to web-1217
(instead of creating new bucket/cloudformation) ...

1. Change ApiHelper Urls
2. Clean/Rebuild
3. cmd on /Client and run 'dotnet publish --configuration Release'
4. Copy _frameworks folder from Release/... to ... Client/wwwroot/
5. cmd on /Client/wwwroot folder and run 'aws s3 sync . s3://web-1217'
6. Test (after ?? minutes/hours) by clearing history on browser (used firefox)... open console ... clear Network, and then load troyclarke.tk

Notes: _frameworks: 13.4MB (same as netlify deploy above)