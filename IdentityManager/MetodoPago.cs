<html lang="en">
  
  <head>
    <title>Address form</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="css/main.css">
    <script src="js/main.js" defer></script>
  </head>

  <body>

    <main>
    
    <form action="#" method="post">

      <h1>Address form</h1>
      
      <section>
        <label for="name">Name</label>
        <input id="name" name="name" autocomplete="name" maxlength="100" pattern="[\p{L} \-\.]+" required>
      </section>

      <section>
        <label for="address">Address</label>
        <textarea id="address" name="address" autocomplete="address" maxlength="300" required></textarea>
      </section>
      <section>
        <label for="postal-code">ZIP or postal code (optional)</label>
        <input id="postal-code" name="postal-code" autocomplete="postal-code" maxlength="20">
      </section>

      <section id="country-region">
        <label for="country">Country or region</label>
        <select id="country" name="country" autocomplete="country" enterkeyhint="done" required>
            <option selected value="SPACER"> </option>
            <option value="AC">Acapulco</option>
            <option value="CAN">Cancun</option>
            <option value="IG">Iguala de la independencia</option>
            <option value="MX">Mexico</option>
            <option value="MOR">Morelos</option>
            <option value="VER">Veracruz</option>
        </select>  
    </section>

    <section>
      <label for="tel">Telephone</label>
      <input id="tel" name="tel" autocomplete="tel" type="tel" maxlength="30" pattern="[\d \-\+]+" required>
    </section>

    <button id="save-address">Save address</button>

  </form>

  <p>Find out more: <a href="https://web.dev/payment-and-address-form-best-practices">Payment&nbsp;and&nbsp;address&nbsp;form&nbsp;best&nbsp;practices</a></p>
  
</main>

</body>

</html>

           