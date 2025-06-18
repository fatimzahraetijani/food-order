<?php include('partials-front/menu.php'); ?>

<!-- Contact Page Section Starts -->
<section class="contact text-center">
    <div class="wrapper">
        <h2>Contact Us</h2>
        <p>If you have any questions or suggestions, feel free to contact us using the form below.</p>

        <form action="#" method="POST" class="contact-form">
            <div class="form-group">
                <input type="text" name="name" placeholder="Your Name" required class="input-field">
            </div>

            <div class="form-group">
                <input type="email" name="email" placeholder="Your Email" required class="input-field">
            </div>

            <div class="form-group">
                <textarea name="message" placeholder="Your Message" required class="input-field" rows="5"></textarea>
            </div>

            <div class="form-group">
                <input type="submit" name="submit" value="Send Message" class="btn-primary">
            </div>
        </form>
    </div>
</section>
<!-- Contact Page Section Ends -->

<?php include('partials-front/footer.php'); ?>
