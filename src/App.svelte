<script>
	import PolicyHeaderField from "./components/PolicyHeaderField.svelte";
	import PageHeader from "./components/PageHeader.svelte";
	import PolicyFieldBuilder from "./components/PolicyFieldBuilder.svelte";
</script>

<style>
	main {
		max-width: var(--main-content-width);
	}
</style>

<PageHeader />

<main>
	<h1>Permissions-Policy</h1>
	<p>
		The
		<em>Permissions-Policy</em>
		header allows for a document to
		<strong>blacklist</strong>
		browser features. If a feature is
		<em>not</em>
		specified in the HTTP header it
		<strong>is allowed</strong>. This header should be set when serving HTML
		content (e.g.
		<code>text/html</code>); use of this header in non-HTML documents (e.g.
		<code>text/javascript</code>) is meaningless.
	</p>
	<h2>Configurator</h2>
	<p>
		Add
		<strong>Features</strong>
		and their corresponding
		<strong>Allowlist</strong>
		below:
	</p>
	<PolicyHeaderField header="foobar" />
	<PolicyFieldBuilder />
</main>
