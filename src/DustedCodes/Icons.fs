module DustedCodes.Icons

open Giraffe.GiraffeViewEngine

let svg (width : float) (height : float) =
    tag "svg" [
        attr "version" "1.0"
        attr "xmlns" "http://www.w3.org/2000/svg"
        attr "viewBox" (sprintf "0 0 %f %f" width height)
    ]

let g      = tag "g"
let circle = tag "circle"
let path   = tag "path"

// ---------------------------------
// Logo
// ---------------------------------

let dustedCodesIcon =
    svg 1240.0 1224.0 [
        g [
            attr "transform" "translate(0.000000,1224.000000) scale(0.100000,-0.100000)"
            attr "fill" "#000000"
            attr "stroke" "none" ] [
            path [
                attr "d" "M7589 8259 c-843 -1640 -1565 -3037 -1602 -3103 -132 -232 -263 -409
-414 -558 -319 -316 -662 -414 -1051 -302 -182 52 -397 174 -533 301 -131 124
-250 314 -308 493 -48 147 -63 255 -58 410 8 200 38 312 134 490 172 320 454
527 826 607 129 28 353 23 478 -10 179 -47 335 -129 451 -236 38 -35 71 -61
74 -58 8 7 1444 2800 1444 2807 0 11 -374 217 -505 277 -487 226 -937 341
-1465 374 -919 57 -2026 -273 -2795 -834 -557 -406 -965 -900 -1290 -1562
-231 -470 -359 -892 -422 -1393 -24 -190 -24 -690 0 -882 91 -725 339 -1393
734 -1975 241 -355 601 -726 963 -992 623 -458 1294 -737 2010 -838 1041 -146
2015 61 2835 601 241 158 417 304 651 538 358 359 642 746 912 1242 135 248
3182 6178 3179 6187 -3 9 -2665 1384 -2698 1394 -11 3 -376 -697 -1550 -2978z"
            ] []
        ]
    ]

// ---------------------------------
// Social media icons
// =================================
// Templates from: https://simpleicons.org/
// ---------------------------------

// view-source:https://www.buymeacoffee.com/assets/img/BMC-btn-logo.svg

let svgIcon (scale : float) (d : string) =
    svg scale scale [
        path [ attr "d" d ] []
    ]

let buyMeACoffeeIcon =
    svg 1024.0 1024.0 [
        path [ attr "d" "M512 768c-84.696 0-153.6-68.904-153.6-153.6s68.904-153.6 153.6-153.6 153.6 68.904 153.6 153.6-68.904 153.6-153.6 153.6zM512 512c-56.464 0-102.4 45.936-102.4 102.4s45.936 102.4 102.4 102.4c56.464 0 102.4-45.936 102.4-102.4s-45.936-102.4-102.4-102.4z" ] []
        path [ attr "d" "M814.302 105.258l-9.050-36.195c-9.682-38.726-48.534-69.062-88.453-69.062h-409.6c-39.918 0-78.771 30.336-88.454 69.062l-9.048 36.195c-32.32 9.062-56.098 38.768-56.098 73.942v51.2c0 33.925 22.118 62.762 52.685 72.899l46.133 645.853c2.947 41.272 39.008 74.848 80.382 74.848h358.4c41.376 0 77.435-33.576 80.382-74.846l46.131-645.853c30.568-10.139 52.686-38.976 52.686-72.901v-51.2c0-35.174-23.778-64.88-56.098-73.942zM307.2 51.2h409.6c16.334 0 34.821 14.434 38.781 30.28l5.23 20.92h-497.622l5.23-20.92c3.96-15.846 22.446-30.28 38.781-30.28zM762.45 358.4h-500.898l-3.658-51.2h508.213l-3.658 51.2zM729.536 819.2h-435.070l-29.258-409.6h493.584l-29.256 409.6zM691.2 972.8h-358.4c-14.834 0-28.256-12.499-29.312-27.294l-5.365-75.106h427.755l-5.365 75.106c-1.058 14.795-14.48 27.294-29.314 27.294zM819.2 230.4c0 14.115-11.485 25.6-25.6 25.6h-563.2c-14.115 0-25.6-11.485-25.6-25.6v-51.2c0-14.093 11.446-25.558 25.531-25.597 0.030 0 0.059 0.003 0.090 0.003 0.050 0 0.099-0.006 0.149-0.006h563.030c14.115 0 25.6 11.485 25.6 25.6v51.2z" ] []
    ]

let disqusIcon = svgIcon 24.0 "M12.438 23.654c-2.853 0-5.46-1.04-7.476-2.766L0 21.568l1.917-4.733C1.25 15.36.875 13.725.875 12 .875 5.564 6.05.346 12.44.346 18.82.346 24 5.564 24 12c0 6.438-5.176 11.654-11.562 11.654zm6.315-11.687v-.033c0-3.363-2.373-5.76-6.462-5.76H7.877V17.83h4.35c4.12 0 6.525-2.5 6.525-5.863h.004zm-6.415 2.998h-1.29V9.04h1.29c1.897 0 3.157 1.08 3.157 2.945v.03c0 1.884-1.26 2.95-3.157 2.95z"

let dockerIcon = svgIcon 24.0 "M4.82 17.275c-.684 0-1.304-.56-1.304-1.24s.56-1.243 1.305-1.243c.748 0 1.31.56 1.31 1.242s-.622 1.24-1.305 1.24zm16.012-6.763c-.135-.992-.75-1.8-1.56-2.42l-.315-.25-.254.31c-.494.56-.69 1.553-.63 2.295.06.562.24 1.12.554 1.554-.254.13-.568.25-.81.377-.57.187-1.124.25-1.68.25H.097l-.06.37c-.12 1.182.06 2.42.562 3.54l.244.435v.06c1.5 2.483 4.17 3.6 7.078 3.6 5.594 0 10.182-2.42 12.357-7.633 1.425.062 2.864-.31 3.54-1.676l.18-.31-.3-.187c-.81-.494-1.92-.56-2.85-.31l-.018.002zm-8.008-.992h-2.428v2.42h2.43V9.518l-.002.003zm0-3.043h-2.428v2.42h2.43V6.48l-.002-.003zm0-3.104h-2.428v2.42h2.43v-2.42h-.002zm2.97 6.147H13.38v2.42h2.42V9.518l-.007.003zm-8.998 0H4.383v2.42h2.422V9.518l-.01.003zm3.03 0h-2.4v2.42H9.84V9.518l-.015.003zm-6.03 0H1.4v2.42h2.428V9.518l-.03.003zm6.03-3.043h-2.4v2.42H9.84V6.48l-.015-.003zm-3.045 0H4.387v2.42H6.8V6.48l-.016-.003z"

let facebookIcon = svgIcon 24.0 "M22.676 0H1.324C.593 0 0 .593 0 1.324v21.352C0 23.408.593 24 1.324 24h11.494v-9.294H9.689v-3.621h3.129V8.41c0-3.099 1.894-4.785 4.659-4.785 1.325 0 2.464.097 2.796.141v3.24h-1.921c-1.5 0-1.792.721-1.792 1.771v2.311h3.584l-.465 3.63H16.56V24h6.115c.733 0 1.325-.592 1.325-1.324V1.324C24 .593 23.408 0 22.676 0"

let githubIcon = svgIcon 24.0 "M12 .297c-6.63 0-12 5.373-12 12 0 5.303 3.438 9.8 8.205 11.385.6.113.82-.258.82-.577 0-.285-.01-1.04-.015-2.04-3.338.724-4.042-1.61-4.042-1.61C4.422 18.07 3.633 17.7 3.633 17.7c-1.087-.744.084-.729.084-.729 1.205.084 1.838 1.236 1.838 1.236 1.07 1.835 2.809 1.305 3.495.998.108-.776.417-1.305.76-1.605-2.665-.3-5.466-1.332-5.466-5.93 0-1.31.465-2.38 1.235-3.22-.135-.303-.54-1.523.105-3.176 0 0 1.005-.322 3.3 1.23.96-.267 1.98-.399 3-.405 1.02.006 2.04.138 3 .405 2.28-1.552 3.285-1.23 3.285-1.23.645 1.653.24 2.873.12 3.176.765.84 1.23 1.91 1.23 3.22 0 4.61-2.805 5.625-5.475 5.92.42.36.81 1.096.81 2.22 0 1.606-.015 2.896-.015 3.286 0 .315.21.69.825.57C20.565 22.092 24 17.592 24 12.297c0-6.627-5.373-12-12-12"

let gmailIcon = svgIcon 24.0 "M24 4.5v15c0 .85-.65 1.5-1.5 1.5H21V7.387l-9 6.463-9-6.463V21H1.5C.649 21 0 20.35 0 19.5v-15c0-.425.162-.8.431-1.068C.7 3.16 1.076 3 1.5 3H2l10 7.25L22 3h.5c.425 0 .8.162 1.069.432.27.268.431.643.431 1.068z"

let googlePlusIcon = svgIcon 24.0 "M7.635 10.909v2.619h4.335c-.173 1.125-1.31 3.295-4.331 3.295-2.604 0-4.731-2.16-4.731-4.823 0-2.662 2.122-4.822 4.728-4.822 1.485 0 2.479.633 3.045 1.178l2.073-1.994c-1.33-1.245-3.056-1.995-5.115-1.995C3.412 4.365 0 7.785 0 12s3.414 7.635 7.635 7.635c4.41 0 7.332-3.098 7.332-7.461 0-.501-.054-.885-.12-1.265H7.635zm16.365 0h-2.183V8.726h-2.183v2.183h-2.182v2.181h2.184v2.184h2.189V13.09H24"

let hackerNewsIcon = svgIcon 24.0 "M0 24V0h24v24H0zM6.951 5.896l4.112 7.708v5.064h1.583v-4.972l4.148-7.799h-1.749l-2.457 4.875c-.372.745-.688 1.434-.688 1.434s-.297-.708-.651-1.434L8.831 5.896h-1.88z"

let instagramIcon = svgIcon 24.0 "M12 0C8.74 0 8.333.015 7.053.072 5.775.132 4.905.333 4.14.63c-.789.306-1.459.717-2.126 1.384S.935 3.35.63 4.14C.333 4.905.131 5.775.072 7.053.012 8.333 0 8.74 0 12s.015 3.667.072 4.947c.06 1.277.261 2.148.558 2.913.306.788.717 1.459 1.384 2.126.667.666 1.336 1.079 2.126 1.384.766.296 1.636.499 2.913.558C8.333 23.988 8.74 24 12 24s3.667-.015 4.947-.072c1.277-.06 2.148-.262 2.913-.558.788-.306 1.459-.718 2.126-1.384.666-.667 1.079-1.335 1.384-2.126.296-.765.499-1.636.558-2.913.06-1.28.072-1.687.072-4.947s-.015-3.667-.072-4.947c-.06-1.277-.262-2.149-.558-2.913-.306-.789-.718-1.459-1.384-2.126C21.319 1.347 20.651.935 19.86.63c-.765-.297-1.636-.499-2.913-.558C15.667.012 15.26 0 12 0zm0 2.16c3.203 0 3.585.016 4.85.071 1.17.055 1.805.249 2.227.415.562.217.96.477 1.382.896.419.42.679.819.896 1.381.164.422.36 1.057.413 2.227.057 1.266.07 1.646.07 4.85s-.015 3.585-.074 4.85c-.061 1.17-.256 1.805-.421 2.227-.224.562-.479.96-.899 1.382-.419.419-.824.679-1.38.896-.42.164-1.065.36-2.235.413-1.274.057-1.649.07-4.859.07-3.211 0-3.586-.015-4.859-.074-1.171-.061-1.816-.256-2.236-.421-.569-.224-.96-.479-1.379-.899-.421-.419-.69-.824-.9-1.38-.165-.42-.359-1.065-.42-2.235-.045-1.26-.061-1.649-.061-4.844 0-3.196.016-3.586.061-4.861.061-1.17.255-1.814.42-2.234.21-.57.479-.96.9-1.381.419-.419.81-.689 1.379-.898.42-.166 1.051-.361 2.221-.421 1.275-.045 1.65-.06 4.859-.06l.045.03zm0 3.678c-3.405 0-6.162 2.76-6.162 6.162 0 3.405 2.76 6.162 6.162 6.162 3.405 0 6.162-2.76 6.162-6.162 0-3.405-2.76-6.162-6.162-6.162zM12 16c-2.21 0-4-1.79-4-4s1.79-4 4-4 4 1.79 4 4-1.79 4-4 4zm7.846-10.405c0 .795-.646 1.44-1.44 1.44-.795 0-1.44-.646-1.44-1.44 0-.794.646-1.439 1.44-1.439.793-.001 1.44.645 1.44 1.439z"

let linkedInIcon = svgIcon 24.0 "M20.447 20.452h-3.554v-5.569c0-1.328-.027-3.037-1.852-3.037-1.853 0-2.136 1.445-2.136 2.939v5.667H9.351V9h3.414v1.561h.046c.477-.9 1.637-1.85 3.37-1.85 3.601 0 4.267 2.37 4.267 5.455v6.286zM5.337 7.433c-1.144 0-2.063-.926-2.063-2.065 0-1.138.92-2.063 2.063-2.063 1.14 0 2.064.925 2.064 2.063 0 1.139-.925 2.065-2.064 2.065zm1.782 13.019H3.555V9h3.564v11.452zM22.225 0H1.771C.792 0 0 .774 0 1.729v20.542C0 23.227.792 24 1.771 24h20.451C23.2 24 24 23.227 24 22.271V1.729C24 .774 23.2 0 22.222 0h.003z"

let linkedInIcon2 = svgIcon 512.0 "M186.4 142.4c0 19-15.3 34.5-34.2 34.5 -18.9 0-34.2-15.4-34.2-34.5 0-19 15.3-34.5 34.2-34.5C171.1 107.9 186.4 123.4 186.4 142.4zM181.4 201.3h-57.8V388.1h57.8V201.3zM273.8 201.3h-55.4V388.1h55.4c0 0 0-69.3 0-98 0-26.3 12.1-41.9 35.2-41.9 21.3 0 31.5 15 31.5 41.9 0 26.9 0 98 0 98h57.5c0 0 0-68.2 0-118.3 0-50-28.3-74.2-68-74.2 -39.6 0-56.3 30.9-56.3 30.9v-25.2H273.8z"

let payPalIcon = svgIcon 24.0 "M6.908 24H3.804c-.664 0-1.086-.529-.936-1.18l.149-.674h2.071c.666 0 1.336-.533 1.482-1.182l1.064-4.592c.15-.648.816-1.18 1.48-1.18h.883c3.789 0 6.734-.779 8.84-2.34s3.16-3.6 3.16-6.135c0-1.125-.195-2.055-.588-2.789 0-.016-.016-.031-.016-.046l.135.075c.75.465 1.32 1.064 1.711 1.814.404.75.598 1.68.598 2.791 0 2.535-1.049 4.574-3.164 6.135-2.1 1.545-5.055 2.324-8.834 2.324h-.9c-.66 0-1.334.525-1.484 1.186L8.39 22.812c-.149.645-.81 1.17-1.47 1.17L6.908 24zm-2.677-2.695H1.126c-.663 0-1.084-.529-.936-1.18L4.563 1.182C4.714.529 5.378 0 6.044 0h6.465c1.395 0 2.609.098 3.648.289 1.035.189 1.92.519 2.684.99.736.465 1.322 1.072 1.697 1.818.389.748.584 1.68.584 2.797 0 2.535-1.051 4.574-3.164 6.119-2.1 1.561-5.056 2.326-8.836 2.326h-.883c-.66 0-1.328.524-1.478 1.169L5.7 20.097c-.149.646-.817 1.172-1.485 1.172l.016.036zm7.446-17.369h-1.014c-.666 0-1.332.529-1.48 1.178l-.93 4.02c-.15.648.27 1.179.93 1.179h.766c1.664 0 2.97-.343 3.9-1.021.929-.686 1.395-1.654 1.395-2.912 0-.83-.301-1.445-.9-1.84-.6-.404-1.5-.605-2.686-.605l.019.001z"

let redditIcon = svgIcon 24.0 "M2.204 14.049c-.06.276-.091.56-.091.847 0 3.443 4.402 6.249 9.814 6.249 5.41 0 9.812-2.804 9.812-6.249 0-.274-.029-.546-.082-.809l-.015-.032c-.021-.055-.029-.11-.029-.165-.302-1.175-1.117-2.241-2.296-3.103-.045-.016-.088-.039-.126-.07-.026-.02-.045-.042-.067-.064-1.792-1.234-4.356-2.008-7.196-2.008-2.815 0-5.354.759-7.146 1.971-.014.018-.029.033-.049.049-.039.033-.084.06-.13.075-1.206.862-2.042 1.937-2.354 3.123 0 .058-.014.114-.037.171l-.008.015zm9.773 5.441c-1.794 0-3.057-.389-3.863-1.197-.173-.174-.173-.457 0-.632.176-.165.46-.165.635 0 .63.629 1.685.943 3.228.943 1.542 0 2.591-.3 3.219-.929.165-.164.45-.164.629 0 .165.18.165.465 0 .645-.809.808-2.065 1.198-3.862 1.198l.014-.028zm-3.606-7.573c-.914 0-1.677.765-1.677 1.677 0 .91.763 1.65 1.677 1.65s1.651-.74 1.651-1.65c0-.912-.739-1.677-1.651-1.677zm7.233 0c-.914 0-1.678.765-1.678 1.677 0 .91.764 1.65 1.678 1.65s1.651-.74 1.651-1.65c0-.912-.739-1.677-1.651-1.677zm4.548-1.595c1.037.833 1.8 1.821 2.189 2.904.45-.336.719-.864.719-1.449 0-1.002-.815-1.816-1.818-1.816-.399 0-.778.129-1.09.363v-.002zM2.711 9.963c-1.003 0-1.817.816-1.817 1.818 0 .543.239 1.048.644 1.389.401-1.079 1.172-2.053 2.213-2.876-.302-.21-.663-.329-1.039-.329v-.002zm9.217 12.079c-5.906 0-10.709-3.205-10.709-7.142 0-.275.023-.544.068-.809C.494 13.598 0 12.729 0 11.777c0-1.496 1.227-2.713 2.725-2.713.674 0 1.303.246 1.797.682 1.856-1.191 4.357-1.941 7.112-1.992l1.812-5.524.404.095s.016 0 .016.002l4.223.993c.344-.798 1.138-1.36 2.065-1.36 1.229 0 2.231 1.004 2.231 2.234 0 1.232-1.003 2.234-2.231 2.234s-2.23-1.004-2.23-2.23l-3.851-.912-1.467 4.477c2.65.105 5.047.854 6.844 2.021.494-.464 1.144-.719 1.833-.719 1.498 0 2.718 1.213 2.718 2.711 0 .987-.54 1.886-1.378 2.365.029.255.059.494.059.749-.015 3.938-4.806 7.143-10.72 7.143l-.034.009zm8.179-19.187c-.74 0-1.34.599-1.34 1.338 0 .738.6 1.34 1.34 1.34.732 0 1.33-.6 1.33-1.334 0-.733-.598-1.332-1.347-1.332l.017-.012z"

let rssFeedIcon = svgIcon 24.0 "M19.199 24C19.199 13.467 10.533 4.8 0 4.8V0c13.165 0 24 10.835 24 24h-4.801zM3.291 17.415c1.814 0 3.293 1.479 3.293 3.295 0 1.813-1.485 3.29-3.301 3.29C1.47 24 0 22.526 0 20.71s1.475-3.294 3.291-3.295zM15.909 24h-4.665c0-6.169-5.075-11.245-11.244-11.245V8.09c8.727 0 15.909 7.184 15.909 15.91z"

let stackOverflowIcon = svgIcon 24.0 "M18.986 21.865v-6.404h2.134V24H1.844v-8.539h2.13v6.404h15.012zM6.111 19.731H16.85v-2.137H6.111v2.137zm.259-4.852l10.48 2.189.451-2.07-10.478-2.187-.453 2.068zm1.359-5.056l9.705 4.53.903-1.95-9.706-4.53-.902 1.936v.014zm2.715-4.785l8.217 6.855 1.359-1.62-8.216-6.853-1.35 1.617-.01.001zM15.751 0l-1.746 1.294 6.405 8.604 1.746-1.294L15.749 0h.002z"

let telegramIcon =
    svg 24.0 24.0 [
        path [ attr "d" "M9.028 20.837c-.714 0-.593-.271-.839-.949l-2.103-6.92L22.263 3.37" ] []
        path [ attr "d" "M9.028 20.837c.552 0 .795-.252 1.105-.553l2.941-2.857-3.671-2.214" ] []
        path [ attr "d" "M9.403 15.213l8.89 6.568c1.015.56 1.748.271 2-.942l3.62-17.053c.372-1.487-.564-2.159-1.534-1.72L1.125 10.263c-1.45.582-1.443 1.392-.264 1.753l5.455 1.7L18.94 5.753c.595-.36 1.143-.167.694.232" ] []
    ]

let tumblrIcon = svgIcon 24.0 "M14.563 24c-5.093 0-7.031-3.756-7.031-6.411V9.747H5.116V6.648c3.63-1.313 4.512-4.596 4.71-6.469C9.84.051 9.941 0 9.999 0h3.517v6.114h4.801v3.633h-4.82v7.47c.016 1.001.375 2.371 2.207 2.371h.09c.631-.02 1.486-.205 1.936-.419l1.156 3.425c-.436.636-2.4 1.374-4.156 1.404h-.178l.011.002z"

let twitterIcon = svgIcon 24.0 "M23.954 4.569c-.885.389-1.83.654-2.825.775 1.014-.611 1.794-1.574 2.163-2.723-.951.555-2.005.959-3.127 1.184-.896-.959-2.173-1.559-3.591-1.559-2.717 0-4.92 2.203-4.92 4.917 0 .39.045.765.127 1.124C7.691 8.094 4.066 6.13 1.64 3.161c-.427.722-.666 1.561-.666 2.475 0 1.71.87 3.213 2.188 4.096-.807-.026-1.566-.248-2.228-.616v.061c0 2.385 1.693 4.374 3.946 4.827-.413.111-.849.171-1.296.171-.314 0-.615-.03-.916-.086.631 1.953 2.445 3.377 4.604 3.417-1.68 1.319-3.809 2.105-6.102 2.105-.39 0-.779-.023-1.17-.067 2.189 1.394 4.768 2.209 7.557 2.209 9.054 0 13.999-7.496 13.999-13.986 0-.209 0-.42-.015-.63.961-.689 1.8-1.56 2.46-2.548l-.047-.02z"

let whatsAppIcon = svgIcon 24.0 "M17.498 14.382c-.301-.15-1.767-.867-2.04-.966-.273-.101-.473-.15-.673.15-.197.295-.771.964-.944 1.162-.175.195-.349.21-.646.075-.3-.15-1.263-.465-2.403-1.485-.888-.795-1.484-1.77-1.66-2.07-.174-.3-.019-.465.13-.615.136-.135.301-.345.451-.523.146-.181.194-.301.297-.496.1-.21.049-.375-.025-.524-.075-.15-.672-1.62-.922-2.206-.24-.584-.487-.51-.672-.51-.172-.015-.371-.015-.571-.015-.2 0-.523.074-.797.359-.273.3-1.045 1.02-1.045 2.475s1.07 2.865 1.219 3.075c.149.195 2.105 3.195 5.1 4.485.714.3 1.27.48 1.704.629.714.227 1.365.195 1.88.121.574-.091 1.767-.721 2.016-1.426.255-.705.255-1.29.18-1.425-.074-.135-.27-.21-.57-.345m-5.446 7.443h-.016c-1.77 0-3.524-.48-5.055-1.38l-.36-.214-3.75.975 1.005-3.645-.239-.375c-.99-1.576-1.516-3.391-1.516-5.26 0-5.445 4.455-9.885 9.942-9.885 2.654 0 5.145 1.035 7.021 2.91 1.875 1.859 2.909 4.35 2.909 6.99-.004 5.444-4.46 9.885-9.935 9.885M20.52 3.449C18.24 1.245 15.24 0 12.045 0 5.463 0 .104 5.334.101 11.893c0 2.096.549 4.14 1.595 5.945L0 24l6.335-1.652c1.746.943 3.71 1.444 5.71 1.447h.006c6.585 0 11.946-5.336 11.949-11.896 0-3.176-1.24-6.165-3.495-8.411"

let yammerIcon = svgIcon 24.0 "M20.852 6.489c.488-.389.611-1.088.268-1.621-.301-.47-.868-.662-1.378-.516l-.14.075c-.813.447-6.306 4.289-5.688 4.723.617.43 4.363-1.258 6.923-2.664m0 11.557c-2.574-1.405-6.321-3.092-6.938-2.664-.617.434 4.86 4.277 5.673 4.723l.137.075c.512.15 1.067-.044 1.368-.515.347-.534.211-1.233-.271-1.62m2.257-7.04c-.061-.015-.105-.015-.166-.015-.932 0-7.584.722-7.253 1.4.331.662 4.424.993 7.344.993.603-.106 1.053-.663 1.009-1.294-.046-.557-.437-1.008-.965-1.113M5.426 16.766c-.752 2.151-1.459 3.16-3.084 3.16-.151 0-.708-.029-.738-.046-.527-.029-1.008.317-1.144.844-.165.588.181 1.203.783 1.385.421.074.873.091 1.264.091 2.98 0 3.973-1.717 4.951-4.229l5.869-14.538c.211-.662-.165-1.354-.813-1.565-.646-.21-1.324.136-1.565.752L6.856 13.455h-.061L2.493 2.546c-.271-.602-.993-.903-1.64-.662-.663.241-1.009.978-.786 1.64l5.427 13.244-.068-.002z"

let youTubeIcon = svgIcon 24.0 "M23.495 6.205a3.007 3.007 0 0 0-2.088-2.088c-1.87-.501-9.396-.501-9.396-.501s-7.507-.01-9.396.501A3.007 3.007 0 0 0 .527 6.205a31.247 31.247 0 0 0-.522 5.805 31.247 31.247 0 0 0 .522 5.783 3.007 3.007 0 0 0 2.088 2.088c1.868.502 9.396.502 9.396.502s7.506 0 9.396-.502a3.007 3.007 0 0 0 2.088-2.088 31.247 31.247 0 0 0 .5-5.783 31.247 31.247 0 0 0-.5-5.805zM9.609 15.601V8.408l6.264 3.602z"

// ---------------------------------
// Other
// ---------------------------------

let calendarIcon = svgIcon 32.0 "M10 12h4v4h-4zM16 12h4v4h-4zM22 12h4v4h-4zM4 24h4v4h-4zM10 24h4v4h-4zM16 24h4v4h-4zM10 18h4v4h-4zM16 18h4v4h-4zM22 18h4v4h-4zM4 18h4v4h-4zM26 0v2h-4v-2h-14v2h-4v-2h-4v32h30v-32h-4zM28 30h-26v-22h26v22z"

let tagIcon = svgIcon 32.0 "M30.5 0h-12c-0.825 0-1.977 0.477-2.561 1.061l-14.879 14.879c-0.583 0.583-0.583 1.538 0 2.121l12.879 12.879c0.583 0.583 1.538 0.583 2.121 0l14.879-14.879c0.583-0.583 1.061-1.736 1.061-2.561v-12c0-0.825-0.675-1.5-1.5-1.5zM23 12c-1.657 0-3-1.343-3-3s1.343-3 3-3 3 1.343 3 3-1.343 3-3 3z"

let commentsIcon = svgIcon 32.0 "M16 6c-1.717 0-3.375 0.271-4.928 0.804-1.46 0.502-2.76 1.211-3.863 2.108-2.069 1.681-3.209 3.843-3.209 6.088 0 1.259 0.35 2.481 1.039 3.63 0.711 1.185 1.781 2.268 3.093 3.133 0.949 0.625 1.587 1.623 1.755 2.747 0.056 0.375 0.091 0.753 0.105 1.129 0.233-0.194 0.461-0.401 0.684-0.624 0.755-0.755 1.774-1.172 2.828-1.172 0.168 0 0.336 0.011 0.505 0.032 0.655 0.083 1.325 0.126 1.99 0.126 1.717 0 3.375-0.271 4.928-0.804 1.46-0.502 2.76-1.211 3.863-2.108 2.069-1.681 3.209-3.843 3.209-6.088s-1.14-4.407-3.209-6.088c-1.104-0.897-2.404-1.606-3.863-2.108-1.553-0.534-3.211-0.804-4.928-0.804zM16 2v0c8.837 0 16 5.82 16 13s-7.163 13-16 13c-0.849 0-1.682-0.054-2.495-0.158-3.437 3.437-7.539 4.053-11.505 4.144v-0.841c2.142-1.049 4-2.961 4-5.145 0-0.305-0.024-0.604-0.068-0.897-3.619-2.383-5.932-6.024-5.932-10.103 0-7.18 7.163-13 16-13z"

let envelopeIcon = svgIcon 612.074 "M612.074,132.141v-2.38c0-8.849-4.016-19.26-11.229-26.473l-0.818-0.818c0,0-0.818,0-0.818-0.818   c-1.636-1.636-3.198-2.38-4.833-4.016c-0.818,0-0.818-0.818-1.636-0.818c-1.636-0.818-4.016-1.636-5.652-2.38   c-0.818,0-0.818-0.818-1.636-0.818c-2.38-0.818-4.833-1.636-7.213-1.636c-0.818,0-0.818,0-1.636,0c-2.38,0-5.651-0.818-8.849-0.818   H43.427c-3.198,0-6.395,0-9.667,0.818c-0.818,0-1.636,0-2.38,0.818c-2.38,0.818-4.834,0.818-6.395,1.636   c-0.818,0-0.818,0.818-1.636,0.818c-1.636,0.818-4.016,1.636-5.652,2.38l-0.818,0.818c-1.636,0.818-3.198,2.38-4.834,3.198   c-0.818,0.818-1.636,1.636-2.38,2.38C4.016,110.428,0.818,117.715,0,125.746c0,0.818,0,0.818,0,1.636v357.384   c0,0.818,0,0.818,0,1.636c1.636,11.229,7.213,20.896,15.244,26.473c7.213,4.833,16.062,8.031,26.473,8.031H569.39c0,0,0,0,0.818,0   l0,0c2.38,0,5.651,0,8.031-0.818c0.818,0,0.818,0,1.636,0c2.38-0.818,4.834-0.818,6.395-1.636h0.818   c17.698-6.395,24.911-21.714,24.911-36.14v-2.38v-0.818v-0.818V134.521c0-0.818,0-0.818,0-1.636   C612.074,132.959,612.074,132.959,612.074,132.141z M560.69,120.913l-252.98,246.51l-57.854-56.218l0,0L51.459,120.838H560.69   V120.913z M29.819,475.099V140.991l187.095,179.882L29.819,475.099z M299.679,491.905H56.292l182.336-149.393l58.597,57.036   c2.38,2.38,4.834,3.198,7.213,4.016h0.818c0.818,0,0.818,0,1.636,0l0,0c0.818,0,1.636,0,1.636,0h0.818   c2.38-0.818,5.651-1.636,7.213-4.016l55.4-53.838l183.079,146.196H299.679z M582.329,475.843L394.417,324.07L582.329,140.99   V475.843z"

let alertIcon = svgIcon 286.054 "M143.027,0C64.04,0,0,64.04,0,143.027c0,78.996,64.04,143.027,143.027,143.027 c78.996,0,143.027-64.022,143.027-143.027C286.054,64.04,222.022,0,143.027,0z M143.027,259.236 c-64.183,0-116.209-52.026-116.209-116.209S78.844,26.818,143.027,26.818s116.209,52.026,116.209,116.209 S207.21,259.236,143.027,259.236z M143.036,62.726c-10.244,0-17.995,5.346-17.995,13.981v79.201c0,8.644,7.75,13.972,17.995,13.972 c9.994,0,17.995-5.551,17.995-13.972V76.707C161.03,68.277,153.03,62.726,143.036,62.726z M143.036,187.723 c-9.842,0-17.852,8.01-17.852,17.86c0,9.833,8.01,17.843,17.852,17.843s17.843-8.01,17.843-17.843 C160.878,195.732,152.878,187.723,143.036,187.723z"