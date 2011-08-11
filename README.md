<div class="wikistyle"><h1>AlceNet-Launcher vb.Net SDK (v.3.1.1)</h1>
<!--
<p>La <a href="http://www.alcenet.info/">plataforma del launcher</a> is
a set of APIs that make your application more social. Read more about
<a href="http://developers.facebook.com/docs/guides/web">integrating Facebook with your web site</a>
on the Facebook developer site.</p>

<p>This repository contains the open source PHP SDK that allows you to utilize the
above on your website. Except as otherwise noted, the Facebook PHP SDK
is licensed under the Apache Licence, Version 2.0
(<a href="http://www.apache.org/licenses/LICENSE-2.0.html">http://www.apache.org/licenses/LICENSE-2.0.html</a>)</p>

<h2>Usage</h2>

<p>The <a href="http://github.com/facebook/php-sdk/blob/master/examples/example.php">examples</a> are a good place to start. The minimal you'll need to
have is:</p>

<pre><code>require 'php-sdk/src/facebook.php';

$facebook = new Facebook(array(
  'appId'  =&gt; 'YOUR_APP_ID',
  'secret' =&gt; 'YOUR_APP_SECRET',
));

// Get User ID
$user = $facebook-&gt;getUser();
</code></pre>

<p>To make <a href="http://developers.facebook.com/docs/api">API</a> calls:</p>

<pre><code>if ($user) {
  try {
    // Proceed knowing you have a logged in user who's authenticated.
    $user_profile = $facebook-&gt;api('/me');
  } catch (FacebookApiException $e) {
    error_log($e);
    $user = null;
  }
}
</code></pre>

<p>Login or logout url will be needed depending on current user state.</p>

<pre><code>if ($user) {
  $logoutUrl = $facebook-&gt;getLogoutUrl();
} else {
  $loginUrl = $facebook-&gt;getLoginUrl();
}

</code></pre>

<h2>Feedback</h2>

<p>File bugs or other issues <a href="http://bugs.developers.facebook.net/">here</a>.</p>

<h2>Tests</h2>

<p>In order to keep us nimble and allow us to bring you new functionality, without
compromising on stability, we have ensured full test coverage of the new SDK.
We are including this in the open source repository to assure you of our
commitment to quality, but also with the hopes that you will contribute back to
help keep it stable. The easiest way to do so is to file bugs and include a
test case.</p>

<p>The tests can be executed by using this command from the base directory:</p>

<pre><code>phpunit --stderr --bootstrap tests/bootstrap.php tests/tests.php
</code></pre>
--></div>