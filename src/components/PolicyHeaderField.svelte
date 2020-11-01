<script>
    import Input from "./Input.svelte";
    export let output = "Permissions-Policy: *";
</script>

<style>
    .policy-header-field {
        display: flex;
        width: 100%;
    }

    .policy-header-field > * {
        flex: 1;
    }

    .policy-header-field > button {
        flex: 0;
    }
</style>

<div class="policy-header-field">
    <Input readonly="readonly" value={output} />
    <button>Copy</button>
</div>
